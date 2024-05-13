using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Commands.AuthCommands;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.AuthHandlers;

public class CreateTokenHandler(ICreateRepository<Auth, AuthCreate> authRepository, IUserRepository userRepository)
    : IHandlerWithResponse<CreateTokenCommand, Auth>
{
    public async Task<Auth> Handle(
        CreateTokenCommand request,
        CancellationToken cancellationToken)
    {
        var user = request.Request;
        ArgumentNullException.ThrowIfNull(user);

        var userModel = await userRepository.GetByUsernameAsync(request.Request.Username);
        if (userModel is null)
        {
            throw new NotFoundException("User");
        }

        if (!await userRepository.IsCredentialsValid(user.Username, user.HashedPassword))
        {
            throw new WrongCredentialsException();
        }

        var key = Encoding.ASCII.GetBytes(request.Options.Key);

        var accessToken = GetAccessToken(userModel, key, request);
        var refreshToken = GetRefreshToken(userModel, key, request);
        
        var authCreate = new AuthCreate
        {
            UserId = userModel.Id,
            Access = accessToken.UnsafeToString(),
            Refresh = refreshToken.UnsafeToString(),
        };
        var auth = await authRepository.CreateAsync(authCreate);
        if (auth is null)
        {
            throw new UnprocessableEntityException();
        }
        
        return auth;
    }

    private SecurityToken GetAccessToken(User userModel, byte[] key, CreateTokenCommand request)
    {
        var userRole = Enum.GetName(userModel.Role)!;

        var securityKey = new SymmetricSecurityKey(key);
        var accessTokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, userModel.Username),
                new Claim(ClaimTypes.NameIdentifier, userModel.Id.ToString()),
                new Claim(ClaimTypes.Role, userRole),
            }),
            Expires = DateTime.UtcNow.AddMinutes(5),
            Issuer = request.Options.Issuer,
            Audience = request.Options.Audience,
            SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature),
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var accessToken = tokenHandler.CreateToken(accessTokenDescriptor);

        return accessToken;
    }
    
    private SecurityToken GetRefreshToken(User userModel, byte[] key, CreateTokenCommand request)
    {
        var userRole = Enum.GetName(userModel.Role)!;

        var securityKey = new SymmetricSecurityKey(key);
        var refreshTokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, userModel.Username),
                new Claim(ClaimTypes.NameIdentifier, userModel.Id.ToString()),
                new Claim(ClaimTypes.Role, userRole),
            }),
            Expires = DateTime.UtcNow.AddDays(90d),
            Issuer = request.Options.Issuer,
            Audience = request.Options.Audience,
            SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature),
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var refreshToken = tokenHandler.CreateToken(refreshTokenDescriptor);

        return refreshToken;
    }
}