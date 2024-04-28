using TimeTracker.Application.Models;

namespace TimeTracker.Application.Contracts.Services;

public interface IUserService : IService<User>
{
    Task<User?> GetByUsernameAsync(string username);
}