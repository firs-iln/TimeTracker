using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Events.Commands.AuthCommands;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Jwt;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController(IMediator mediator, JwtOptions jwtOptions) : ControllerBase
{
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> CreateAsync([FromBody] AuthenticateRequest? request)
    {
        if (request == null)
        {
            Log.Logger.Warning("BadRequest: request is null");
            return BadRequest();
        }

        try
        {
            var auth = await mediator.Send(new CreateTokenCommand(request, jwtOptions));
            return Ok(auth);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
        catch (WrongCredentialsException)
        {
            return Unauthorized();
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            Log.Logger.Warning("BadRequest: unknown error");
            return BadRequest();
        }
    }

    [HttpPost("/update")]
    [AllowAnonymous]
    public async Task<IActionResult> UpdateToken([FromBody] AuthUpdateRequest request)
    {
        try
        {
            var newTokenCommand = await mediator.Send(new UpdateTokenCommand(request, jwtOptions));
            var newToken = await mediator.Send(newTokenCommand);
            return Ok(newToken);
        }
        catch (WrongCredentialsException)
        {
            return Unauthorized();
        }
        catch (TokenExpiredException)
        {
            return Unauthorized();
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            return BadRequest();
        }
    }
}