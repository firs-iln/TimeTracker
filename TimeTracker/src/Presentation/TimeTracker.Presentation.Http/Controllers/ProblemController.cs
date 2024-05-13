using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class ProblemController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(Problem), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [Authorize]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var problem = await mediator.Send(new GetOneByIdQuery<Problem>(id));
            return Ok(problem);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Problem>), (int)HttpStatusCode.OK)]
    [Authorize]
    public async Task<IActionResult> GetAllAsync()
    {
        var problems = await mediator.Send(new GetAllQuery<Problem>());
        return Ok(problems);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Problem), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [Authorize]
    public async Task<IActionResult> CreateAsync([FromBody] ProblemCreate? problem)
    {
        if (problem == null)
        {
            return BadRequest();
        }

        try
        {
            var created = await mediator.Send(new CreateOneCommand<Problem, ProblemCreate>(problem));
            return CreatedAtAction("Get", new { id = created.Id }, created);
        }
        catch (UnprocessableEntityException)
        {
            return BadRequest();
        }
    }
    
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(Problem), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [Authorize]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] ProblemUpdate? problem)
    {
        if (problem == null)
        {
            return BadRequest();
        }

        try
        {
            var updated = await mediator.Send(new UpdateOneCommand<Problem, ProblemUpdate>(id, problem));
            return Ok(updated);
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
}