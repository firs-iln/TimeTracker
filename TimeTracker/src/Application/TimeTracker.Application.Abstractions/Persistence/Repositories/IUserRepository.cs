using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IUserRepository : ICrudRepository<User>
{
    public Task<User?> GetByUsernameAsync(string username);
}