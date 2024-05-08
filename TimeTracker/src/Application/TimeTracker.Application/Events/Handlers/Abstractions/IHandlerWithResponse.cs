using MediatR;

namespace TimeTracker.Application.Events.Handlers.Abstractions;

public interface IHandlerWithResponse<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>, IHandler
    where TRequest : IRequest<TResponse>
    where TResponse : class;