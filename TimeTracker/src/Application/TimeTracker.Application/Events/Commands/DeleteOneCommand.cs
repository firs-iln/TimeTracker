using MediatR;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Commands;

public class DeleteOneCommand<TModel>(Guid id) : IRequest
    where TModel : BaseModel
{
    public Guid Id { get; set; } = id;
}