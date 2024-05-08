using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public abstract class GetOneHandler<TRequest, TResponse>
    : IHandlerWithResponse<TRequest, TResponse>
    where TRequest : GetOneQuery<TResponse>
    where TResponse : BaseModel
{
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}