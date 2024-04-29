using System.Linq.Expressions;
using TimeTracker.Application.Models.Abstractions;
using Task = System.Threading.Tasks.Task;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;
public interface ICrudRepository<TModel, TCreateDto, TUpdateDto>
    where TModel : BaseModel
    where TCreateDto : class
    where TUpdateDto : class
{
    public Task<TModel?> GetAsync(Guid id);

    public Task<TModel?> CreateAsync(TCreateDto model);

    public Task<IEnumerable<TModel?>> GetAllAsync();

    public Task<IEnumerable<TModel?>> GetByFilterAsync(Expression<Func<TModel?, bool>> filter);

    public Task<TModel> UpdateAsync(Guid id, TUpdateDto model);

    public Task DeleteAsync(Guid id);
}