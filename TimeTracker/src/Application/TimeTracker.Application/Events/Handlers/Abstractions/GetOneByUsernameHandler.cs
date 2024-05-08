using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public class GetOneByUsernameHandler<TResponse>(IGetByUsernameRepository<TResponse> repository)
    : GetOneHandler<GetOneByUsernameQuery<TResponse>, TResponse>
    where TResponse : BaseModel
{
    public override async Task<TResponse> Handle(GetOneByUsernameQuery<TResponse> request, CancellationToken cancellationToken)
    {
        var result = await repository.GetByUsernameAsync(request.Username);
        if (result is null)
        {
            throw new NotFoundException(nameof(TResponse));
        }

        return result;
    }
}