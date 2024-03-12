using System.Linq.Expressions;
using TimeTracker.Application.Models;
using TimeTracker.Application.Abstractions.Crud;

namespace TimeTracker.Application.Contracts.Services;

public abstract class Service<TRepository, TEntity>(TRepository repository)
    where TRepository : ICrudRepository<TEntity>
    where TEntity : Entity
{
    private readonly TRepository _repository = repository;

    public async Task<TEntity> GetAsync(Guid id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        return await _repository.CreateAsync(entity);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<IEnumerable<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await _repository.GetByFilterAsync(filter);
    }

    public async Task<TEntity> UpdateAsync(Guid id, TEntity entity)
    {
        return await _repository.UpdateAsync(id, entity);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
        // await Task.Run(() => _repository.DeleteAsync(id));
    }
}
