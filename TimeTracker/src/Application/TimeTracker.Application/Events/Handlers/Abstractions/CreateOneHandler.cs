using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public class CreateOneHandler<TCreateDto, TResponse>(ICreateRepository<TResponse, TCreateDto> repository) 
    : IHandlerWithResponse<CreateOneCommand<TResponse, TCreateDto>, TResponse>
    where TResponse : BaseModel
    where TCreateDto : class
{
    public async Task<TResponse> Handle(CreateOneCommand<TResponse, TCreateDto> request, CancellationToken cancellationToken)
    {
        var instance = await repository.CreateAsync(request.CreateDto);
        if (instance is null)
        {
            throw new UnprocessableEntityException();
        }

        return instance;
    }
}