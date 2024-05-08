using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;

public interface IDeleteRepository<TModel>
    where TModel : BaseModel
{
    public Task DeleteAsync(Guid id);
}