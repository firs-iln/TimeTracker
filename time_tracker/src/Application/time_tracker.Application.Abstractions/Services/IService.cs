using System.Linq.Expressions;
using time_tracker.Application.Abstractions.Crud;

namespace time_tracker.Application.Contracts.Services;

public interface IService<T>
    where T : ICrudRepository<Dto>
{
    public Task<Dto> GetAsync(Guid id);
    public Task<Dto> CreateAsync(T entity);
    public Task<IEnumerable<Dto>> GetAllAsync();
    public Task<IEnumerable<Dto>> GetByFilterAsync(Expression<Func<Dto, bool>> filter);
    public Task<Dto> UpdateAsync(Guid id, Dto entity);
    public Task DeleteAsync(Guid id);
}
