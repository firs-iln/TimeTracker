using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface ICrudRepository<TModel, in TCreateDto, in TUpdateDto>
    : IGetByIdRepository<TModel>,
        IGetAllRepository<TModel>,
        ICreateRepository<TModel, TCreateDto>,
        IUpdateRepository<TModel, TUpdateDto>,
        IDeleteRepository<TModel>
    where TModel : BaseModel
    where TCreateDto : class
    where TUpdateDto : class;