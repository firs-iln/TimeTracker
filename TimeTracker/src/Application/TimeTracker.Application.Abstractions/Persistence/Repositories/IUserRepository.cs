using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IUserRepository : ICrudRepository<User, UserCreate, UserUpdate>
{
    public Task<User?> GetByUsernameAsync(string username);
}