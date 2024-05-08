using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;

public interface IGetAllRepository<TModel>
    where TModel : BaseModel
{
    public Task<IEnumerable<TModel?>> GetAllAsync();
}