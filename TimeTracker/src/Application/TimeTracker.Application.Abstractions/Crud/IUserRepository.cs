using System.Linq.Expressions;
using TimeTracker.Application.Models.User;

namespace TimeTracker.Application.Abstractions.Crud;

public class IUserRepository : ICrudRepository<User>
{
    public Task<User> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> CreateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetByFilterAsync(Expression<Func<User, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateAsync(Guid id, User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}