using System.Linq.Expressions;
using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Contracts.Services.Abstractions;
using UserModel = TimeTracker.Application.Models.User;

namespace TimeTracker.Application.Contracts.Services.User;

public interface IUserService : IService<UserModel, UserCreate, UserUpdate>
{
    Task<UserModel?> GetByUsernameAsync(string username);

    new Task<UserModel?> CreateAsync(UserCreate model);

    new Task<IEnumerable<UserModel?>> GetAllAsync();

    new Task<IEnumerable<UserModel?>> GetByFilterAsync(Expression<Func<UserModel, bool>> filter);

    new Task<UserModel?> UpdateAsync(Guid id, UserUpdate model);

    new Task DeleteAsync(Guid id);
}