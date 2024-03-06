using System.Linq.Expressions;

namespace TimeTracker.Application.Abstractions.Crud;

public interface ICrudRepository<T>
    where T : Dto
{
    public Task<T> GetAsync(Guid id);
    public Task<T> CreateAsync(T entity);
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<IEnumerable<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);
    public Task<T> UpdateAsync(Guid id, T entity);
    public Task DeleteAsync(Guid id);
}