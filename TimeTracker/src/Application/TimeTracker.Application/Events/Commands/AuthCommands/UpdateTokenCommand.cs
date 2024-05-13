using MediatR;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Jwt;

namespace TimeTracker.Application.Events.Commands.AuthCommands;

public class UpdateTokenCommand(AuthUpdateRequest request, JwtOptions options)
    : IRequest<CreateTokenCommand>
{
    public AuthUpdateRequest Request { get; } = request;

    public JwtOptions Options { get; } = options;
}