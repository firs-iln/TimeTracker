using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.Auth;

public interface IAuthService : IService<Models.Auth, AuthCreate, AuthUpdate>
{
    Task RevokeTokenAsync(string token);
    
    Task<Models.Auth?> GetByRefreshTokenAsync(string token);
    
    Task<Models.Auth?> GetByUserIdAsync(Guid userId);
}