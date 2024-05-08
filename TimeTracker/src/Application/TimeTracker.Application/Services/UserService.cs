using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.User;
using TimeTracker.Application.Models;
using TimeTracker.Application.Services.Abstractions;

namespace TimeTracker.Application.Services;

public class UserService(IUserRepository repository)
    : Service<IUserRepository, User, UserCreate, UserUpdate>(repository), IUserService
{
    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await Repository.GetByUsernameAsync(username);
    }
}