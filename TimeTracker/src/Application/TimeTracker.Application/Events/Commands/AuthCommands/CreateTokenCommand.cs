using MediatR;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Jwt;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Commands.AuthCommands;

public class CreateTokenCommand(AuthenticateRequest request, JwtOptions options)
    : IRequest<Auth>
{
    public AuthenticateRequest Request { get; } = request;

    public JwtOptions Options { get; } = options;
}