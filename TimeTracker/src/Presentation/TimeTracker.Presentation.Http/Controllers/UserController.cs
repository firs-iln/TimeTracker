using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    [HttpGet("{username}")]
    [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [Authorize]
    public async Task<IActionResult> GetByUsernameAsync(string username)
    {
        try
        {
            var user = await mediator.Send(new GetOneByUsernameQuery<User>(username));
            return Ok(user);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [Authorize]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var user = await mediator.Send(new GetOneByIdQuery<User>(id));
            return Ok(user);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPost]
    [ProducesResponseType(typeof(User), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [Authorize]
    public async Task<IActionResult> CreateAsync([FromBody] UserCreate? user)
    {
        if (user == null)
        {
            return BadRequest();
        }

        try
        {
            var createdUser = await mediator.Send(new CreateOneCommand<User, UserCreate>(user));
            return CreatedAtAction("Get", new { id = createdUser.Id }, createdUser);
        }
        catch (UnprocessableEntityException)
        {
            return BadRequest();
        }
    }
    
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [Authorize]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UserUpdate? user)
    {
        if (user == null)
        {
            return BadRequest();
        }

        try
        {
            var updatedUser = await mediator.Send(new UpdateOneCommand<User, UserUpdate>(id, user));
            return Ok(updatedUser);
        }
        catch (NotFoundByIdException)
        {
            return NotFound();
        }
        catch (UnprocessableEntityException)
        {
            return BadRequest();
        }
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<User>), (int)HttpStatusCode.OK)]
    [Authorize]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await mediator.Send(new GetAllQuery<User>());
        return Ok(users);
    }
}