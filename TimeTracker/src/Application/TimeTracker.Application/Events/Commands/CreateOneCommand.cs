using MediatR;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Commands;

public class CreateOneCommand<TModel, TCreateDto>(TCreateDto createDto) : IRequest<TModel>
    where TModel : BaseModel
    where TCreateDto : class
{
    public TCreateDto CreateDto { get; set; } = createDto;
}