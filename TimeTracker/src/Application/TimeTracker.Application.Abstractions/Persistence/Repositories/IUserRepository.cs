using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IUserRepository
    : ICrudRepository<User, UserCreate, UserUpdate>, IGetByUsernameRepository<User>
{
    public Task<bool> IsCredentialsValid(string username, string password);
}