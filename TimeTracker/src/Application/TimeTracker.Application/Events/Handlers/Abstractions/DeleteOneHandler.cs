using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public class DeleteOneHandler<TModel>(IDeleteRepository<TModel> repository)
    : IHandlerWithoutResponse<DeleteOneCommand<TModel>>
    where TModel : BaseModel
{
    public async Task Handle(DeleteOneCommand<TModel> request, CancellationToken cancellationToken)
    {
        await repository.DeleteAsync(request.Id);
    }
}