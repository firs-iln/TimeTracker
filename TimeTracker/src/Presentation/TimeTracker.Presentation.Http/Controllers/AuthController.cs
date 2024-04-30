using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Contracts.Services.Auth;
using TimeTracker.Application.Exceptions;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController(IAuthService authService) : ControllerBase
{
    [HttpGet("{userId:guid}")]
    public async Task<IActionResult> GetByUserIdAsync(Guid userId)
    {
        var auth = await authService.GetByUserIdAsync(userId);
        if (auth == null)
        {
            return NotFound();
        }

        return Ok(auth);
    }

    [HttpGet("{token}")]
    public async Task<IActionResult> GetByRefreshTokenAsync(string token)
    {
        var auth = await authService.GetByRefreshTokenAsync(token);
        if (auth == null)
        {
            return NotFound();
        }

        return Ok(auth);
    }

    [HttpGet("{token}/revoke")]
    public async Task<IActionResult> RevokeTokenAsync(string token)
    {
        await authService.RevokeTokenAsync(token);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] AuthenticateRequest? request)
    {
        if (request == null)
        {
            return BadRequest();
        }

        try
        {
            var auth = await authService.CreateToken(request);
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
        catch
        {
            return BadRequest();
        }
    }
}