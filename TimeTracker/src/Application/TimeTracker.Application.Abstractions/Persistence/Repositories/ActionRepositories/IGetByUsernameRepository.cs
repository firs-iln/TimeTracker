using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;

public interface IGetByUsernameRepository<TModel>
    where TModel : BaseModel
{
    public Task<TModel?> GetByUsernameAsync(string username);
}