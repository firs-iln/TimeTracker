using System.Linq.Expressions;
using TimeTracker.Application.Models.Abstractions;
using Task = System.Threading.Tasks.Task;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;
public interface ICrudRepository<TModel>
    where TModel : BaseModel
{
    public Task<TModel?> GetAsync(Guid id);

    public Task<TModel?> CreateAsync(TModel entity);

    public Task<IEnumerable<TModel?>> GetAllAsync();

    public Task<IEnumerable<TModel?>> GetByFilterAsync(Expression<Func<TModel?, bool>> filter);

    public Task<TModel> UpdateAsync(Guid id, TModel entity);

    public Task DeleteAsync(Guid id);
}