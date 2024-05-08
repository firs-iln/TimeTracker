using MediatR;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public interface IHandlerWithoutResponse<in TRequest> : IRequestHandler<TRequest>, IHandler
    where TRequest : IRequest;