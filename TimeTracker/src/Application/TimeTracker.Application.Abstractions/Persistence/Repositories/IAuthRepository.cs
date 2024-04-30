using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IAuthRepository : ICrudRepository<Auth, AuthCreate, AuthUpdate>
{
    Task RevokeTokenAsync(string token);

    Task<Auth?> GetByRefreshTokenAsync(string token);

    Task<Auth?> GetByUserIdAsync(Guid userId);
}