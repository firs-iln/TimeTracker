using System.Linq.Expressions;

namespace TimeTracker.Application.Contracts.Services;

public interface IService<TModel>
{
    Task<TModel?> GetAsync(Guid id);

    Task<TModel?> CreateAsync(TModel model);

    Task<IEnumerable<TModel?>> GetAllAsync();

    Task<IEnumerable<TModel?>> GetByFilterAsync(Expression<Func<TModel, bool>> filter);

    Task<TModel?> UpdateAsync(Guid id, TModel model);

    Task DeleteAsync(Guid id);
}