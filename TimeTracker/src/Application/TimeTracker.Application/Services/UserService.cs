using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.User;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class UserService(IUserRepository repository)
    : Service<IUserRepository, User, UserCreate, UserUpdate>(repository), IUserService
{
    private readonly IUserRepository _repository = repository;

    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await _repository.GetByUsernameAsync(username);
    }
}