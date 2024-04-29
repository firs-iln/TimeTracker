using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Contracts.Services.Abstractions;
using UserModel = TimeTracker.Application.Models.User;

namespace TimeTracker.Application.Contracts.Services.User;

public interface IUserService : IService<UserModel, UserCreate, UserUpdate>
{
    Task<UserModel?> GetByUsernameAsync(string username);
}