using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Contracts.Services;
using TimeTracker.Application.Models;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpGet("{username}")]
    public async Task<IActionResult> GetByUsernameAsync(string username)
    {
        var user = await userService.GetByUsernameAsync(username);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var user = await userService.GetAsync(id);
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] User? user)
    {
        if (user == null)
        {
            return BadRequest();
        }

        var createdUser = await userService.CreateAsync(user);
        if (createdUser != null)
        {
            return CreatedAtAction("Get", new { id = createdUser.Id }, createdUser);
        }

        return BadRequest();
    }
}