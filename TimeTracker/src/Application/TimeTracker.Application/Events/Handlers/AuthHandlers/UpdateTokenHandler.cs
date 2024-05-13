using System.IdentityModel.Tokens.Jwt;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Events.Commands.AuthCommands;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Exceptions;

namespace TimeTracker.Application.Events.Handlers.AuthHandlers;

public class UpdateTokenHandler(IAuthRepository authRepository, IUserRepository userRepository)
    : IHandlerWithResponse<UpdateTokenCommand, CreateTokenCommand>
{
    public async Task<CreateTokenCommand> Handle(UpdateTokenCommand request, CancellationToken cancellationToken)
    {
        var existingToken = await authRepository.GetByRefreshTokenAsync(request.Request.Refresh);
        if (existingToken is null)
        {
            throw new WrongCredentialsException();
        }

        var handler = new JwtSecurityTokenHandler();
        var refreshToken = (JwtSecurityToken)handler.ReadToken(existingToken.Refresh);

        handler = new JwtSecurityTokenHandler();

        if (handler.ReadToken(existingToken.Access) is not JwtSecurityToken || refreshToken is null)
        {
            throw new WrongCredentialsException();
        }

        var userId = Guid.Parse(refreshToken.Payload.Claims.First(claim => claim.Type == "sub").Value);
        var user = await userRepository.GetAsync(userId);
        if (user is null)
        {
            throw new WrongCredentialsException();
        }

        var exp = DateTime.Parse(refreshToken.Payload.Claims.First(claim => claim.Type == "sub").Value);
        if (exp > DateTime.Now)
        {
            throw new TokenExpiredException();
        }

        return new CreateTokenCommand(
            new AuthenticateRequest
                { Username = user.Username, HashedPassword = user.HashedPassword },
            request.Options);
    }
}