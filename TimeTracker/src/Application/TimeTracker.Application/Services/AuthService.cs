using System.Linq.Expressions;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.Auth;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class AuthService(IAuthRepository repository) :
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
}