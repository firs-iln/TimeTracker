using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;

public interface ICreateRepository<TModel, in TCreateDto>
    where TModel : BaseModel
    where TCreateDto : class
{
    public Task<TModel?> CreateAsync(TCreateDto model);
}