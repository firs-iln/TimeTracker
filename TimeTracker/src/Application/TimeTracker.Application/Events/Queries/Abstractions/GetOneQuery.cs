using MediatR;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Queries.Abstractions;

public abstract class GetOneQuery<TModel> : IRequest<TModel>
    where TModel : BaseModel;