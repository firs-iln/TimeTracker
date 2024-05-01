using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.CompilerServices;
using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Contracts.Services.User;
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
    public async Task<IActionResult> CreateAsync([FromBody] UserCreate? user)
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
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UserUpdate? user)
    {
        if (user == null)
        {
            return BadRequest();
        }

        var updatedUser = await userService.UpdateAsync(id, user);
        if (updatedUser != null)
        {
            return Ok(updatedUser);
        }

        return BadRequest();
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<User>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await userService.GetAllAsync();
        return Ok(users);
    }
}