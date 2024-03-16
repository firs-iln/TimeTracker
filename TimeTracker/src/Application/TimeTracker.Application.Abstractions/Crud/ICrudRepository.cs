using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimeTracker.Application.Abstractions.Crud;

using System.Linq.Expressions;
using TimeTracker.Application.Models;

public interface ICrudRepository<T>
    where T : Entity
{
    public Task<T> GetAsync(Guid id);

    public Task<T> CreateAsync(T entity);

    public Task<IEnumerable<T>> GetAllAsync();

    public Task<IEnumerable<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);

    public Task<T> UpdateAsync(Guid id, T entity);

    public Task DeleteAsync(Guid id);
}