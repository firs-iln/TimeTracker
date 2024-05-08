using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public class GetOneByIdHandler<TResponse>(IGetByIdRepository<TResponse> repository)
    : GetOneHandler<GetOneByIdQuery<TResponse>, TResponse>
    where TResponse : BaseModel
{
    public override async Task<TResponse> Handle(GetOneByIdQuery<TResponse> request, CancellationToken cancellationToken)
    {
        var result = await repository.GetAsync(request.Id);
        if (result is null)
        {
            throw new NotFoundException(nameof(TResponse));
        }

        return result;
    }
}