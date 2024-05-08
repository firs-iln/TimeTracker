using MediatR;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Commands;

public class UpdateOneCommand<TModel, TUpdateDto>(Guid id, TUpdateDto updateDto) : IRequest<TModel>
    where TModel : BaseModel
    where TUpdateDto : class
{
    public Guid Id { get; set; } = id;

    public TUpdateDto UpdateDto { get; set; } = updateDto;
}