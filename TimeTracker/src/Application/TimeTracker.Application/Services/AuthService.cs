using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Auth;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;
using TimeTracker.Application.Services.Abstractions;

namespace TimeTracker.Application.Services;

public class AuthService(IAuthRepository repository, IUserRepository userRepository) :
    Service<IAuthRepository, Auth, AuthCreate, AuthUpdate>(repository), IAuthService
{
    public async Task RevokeTokenAsync(string token)
    {
        await Repository.RevokeTokenAsync(token);
    }

    public async Task<Auth?> GetByRefreshTokenAsync(string token)
    {
        return await Repository.GetByRefreshTokenAsync(token);
    }

    public async Task<Auth?> GetByUserIdAsync(Guid userId)
    {
        return await Repository.GetByUserIdAsync(userId);
    }

    public async Task<Auth?> CreateToken(AuthenticateRequest request)
    {
        var user = await userRepository.GetByUsernameAsync(request.Username);
        if (user == null)
        {
            throw new NotFoundException("User");
        }

        if (user.HashedPassword != request.HashedPassword)
        {
            throw new WrongCredentialsException();
        }

        var existingAuth = await GetByUserIdAsync(user.Id);
        if (existingAuth != null)
        {
            return existingAuth;
        }

        var authToCreate = new AuthCreate
        {
            UserId = user.Id,
            Refresh = "string",
            Access = "string",
        };

        return await Repository.CreateAsync(authToCreate);
    }
}