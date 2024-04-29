using System.Linq.Expressions;

namespace TimeTracker.Application.Contracts.Services.Abstractions;

public interface IService<TModel, TCreateDto, TUpdateDto>
{
    Task<TModel?> GetAsync(Guid id);

    Task<TModel?> CreateAsync(TCreateDto model);

    Task<IEnumerable<TModel?>> GetAllAsync();

    Task<IEnumerable<TModel?>> GetByFilterAsync(Expression<Func<TModel, bool>> filter);

    Task<TModel?> UpdateAsync(Guid id, TUpdateDto model);

    Task DeleteAsync(Guid id);
}