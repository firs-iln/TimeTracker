using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Queries;

public class GetOneByIdQuery<TModel>(Guid id) : GetOneQuery<TModel>
    where TModel : BaseModel
{
    public Guid Id { get; set; } = id;
}