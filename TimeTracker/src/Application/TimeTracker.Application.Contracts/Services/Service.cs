using System.Linq.Expressions;
using TimeTracker.Application.Models;
using TimeTracker.Application.Abstractions.Crud;

namespace TimeTracker.Application.Contracts.Services;

public abstract class Service<T>(T repository)
    where T : ICrudRepository<Dto>
{
    private readonly T _repository = repository;

    public Task<Dto> GetAsync(Guid id)
    {
        return _repository.GetAsync(id);
    }

    public Task<Dto> CreateAsync(Dto entity)
    {
        return _repository.CreateAsync(entity);
    }

    public Task<IEnumerable<Dto>> GetAllAsync()
    {
        return _repository.GetAllAsync();
    }

    public Task<IEnumerable<Dto>> GetByFilterAsync(Expression<Func<Dto, bool>> filter)
    {
        return _repository.GetByFilterAsync(filter);
    }

    public Task<Dto> UpdateAsync(Guid id, Dto entity)
    {
        return _repository.UpdateAsync(id, entity);
    }

    public Task DeleteAsync(Guid id)
    {
        return _repository.DeleteAsync(id);
    }
}
