namespace TimeTracker.Application.Contracts.Services.Abstractions;

public interface IService<TModel, TCreateDto, TUpdateDto>
{
    Task<TModel?> GetAsync(Guid id);

    Task<TModel?> CreateAsync(TCreateDto model);

    Task<IEnumerable<TModel?>> GetAllAsync();

    Task<TModel?> UpdateAsync(Guid id, TUpdateDto model);

    Task DeleteAsync(Guid id);
}