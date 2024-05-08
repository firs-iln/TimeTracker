using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;

public interface IUpdateRepository<TModel, in TUpdateDto>
    where TModel : BaseModel
    where TUpdateDto : class
{
    public Task<TModel> UpdateAsync(Guid id, TUpdateDto model);
}