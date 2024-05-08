using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public class GetAllHandler<TResponse>(IGetAllRepository<TResponse> repository)
    : IHandlerWithResponse<GetAllQuery<TResponse>, IEnumerable<TResponse>>
    where TResponse : BaseModel
{
    public async Task<IEnumerable<TResponse>> Handle(GetAllQuery<TResponse> request, CancellationToken cancellationToken)
    {
        var response = await repository.GetAllAsync();
        return response!;
    }
}