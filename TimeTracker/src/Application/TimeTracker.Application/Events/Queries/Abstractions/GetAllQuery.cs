using MediatR;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Queries.Abstractions;

public class GetAllQuery<TModel> : IRequest<IEnumerable<TModel>>
    where TModel : BaseModel;