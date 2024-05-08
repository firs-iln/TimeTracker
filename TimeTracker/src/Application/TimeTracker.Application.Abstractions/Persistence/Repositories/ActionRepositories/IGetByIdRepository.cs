using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;

public interface IGetByIdRepository<TModel>
    where TModel : BaseModel
{
    public Task<TModel?> GetAsync(Guid id);
}