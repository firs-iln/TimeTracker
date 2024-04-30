using System.Linq.Expressions;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Models.Abstractions;
using Task = System.Threading.Tasks.Task;

namespace TimeTracker.Application.Contracts.Services.Abstractions;
public abstract class Service<TRepository, TModel, TCreateDto, TUpdateDto>(TRepository repository) : IService<TModel, TCreateDto, TUpdateDto>
    where TRepository : ICrudRepository<TModel, TCreateDto, TUpdateDto>
    where TModel : BaseModel
    where TCreateDto : class
    where TUpdateDto : class
{
    protected readonly TRepository Repository = repository;

    public async Task<TModel?> GetAsync(Guid id)
    {
        return await Repository.GetAsync(id);
    }

    public async Task<TModel?> CreateAsync(TCreateDto model)
    {
        return await Repository.CreateAsync(model);
    }

    public async Task<IEnumerable<TModel?>> GetAllAsync()
    {
        return await Repository.GetAllAsync();
    }

    public Task<IEnumerable<TModel?>> GetByFilterAsync(Expression<Func<TModel, bool>> filter)
    {
        // return await _repository.GetByFilterAsync(filter);
        throw new NotImplementedException();
    }

    public async Task<TModel?> UpdateAsync(Guid id, TUpdateDto model)
    {
        return await Repository.UpdateAsync(id, model);
    }
    
    public Task DeleteAsync(Guid id)
    {
        return Repository.DeleteAsync(id);
    }
}
