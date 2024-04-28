using System.Linq.Expressions;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Models.Abstractions;
using Task = System.Threading.Tasks.Task;

namespace TimeTracker.Application.Contracts.Services;
public abstract class Service<TRepository, TModel>(TRepository repository) : IService<TModel>
    where TRepository : ICrudRepository<TModel>
    where TModel : BaseModel
{
    private readonly TRepository _repository = repository;

    public async Task<TModel?> GetAsync(Guid id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task<TModel?> CreateAsync(TModel model)
    {
        return await _repository.CreateAsync(model);
    }

    public async Task<IEnumerable<TModel?>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public Task<IEnumerable<TModel?>> GetByFilterAsync(Expression<Func<TModel, bool>> filter)
    {
        // return await _repository.GetByFilterAsync(filter);
        throw new NotImplementedException();
    }

    public async Task<TModel?> UpdateAsync(Guid id, TModel model)
    {
        return await _repository.UpdateAsync(id, model);
    }

    public Task DeleteAsync(Guid id)
    {
        return _repository.DeleteAsync(id);
    }
}
