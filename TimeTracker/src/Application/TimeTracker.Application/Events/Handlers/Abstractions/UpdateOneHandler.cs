using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public class UpdateOneHandler<TUpdateDto, TResponse>(IUpdateRepository<TResponse, TUpdateDto> repository)
    : IHandlerWithResponse<UpdateOneCommand<TResponse, TUpdateDto>, TResponse>
    where TResponse : BaseModel
    where TUpdateDto : class
{
    public async Task<TResponse> Handle(UpdateOneCommand<TResponse, TUpdateDto> request, CancellationToken cancellationToken)
    {
        var updatedInstance = await repository.UpdateAsync(request.Id, request.UpdateDto);
        return updatedInstance;
    }
}