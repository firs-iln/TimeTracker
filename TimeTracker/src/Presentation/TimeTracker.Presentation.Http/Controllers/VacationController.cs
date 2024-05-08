using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class VacationController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(Vacation), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var vacation = await mediator.Send(new GetOneByIdQuery<Vacation>(id));
            return Ok(vacation);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Vacation>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsync()
    {
        var vacations = await mediator.Send(new GetAllQuery<Vacation>());
        return Ok(vacations);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Vacation), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> CreateAsync([FromBody] VacationCreate? vacation)
    {
        if (vacation == null)
        {
            return BadRequest();
        }

        try
        {
            var created = await mediator.Send(new CreateOneCommand<Vacation, VacationCreate>(vacation));
            return CreatedAtAction("Get", new { id = created.Id }, created);
        }
        catch (UnprocessableEntityException)
        {
            return BadRequest();
        }
    }
    
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(Vacation), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] VacationUpdate? vacation)
    {
        if (vacation == null)
        {
            return BadRequest();
        }

        try
        {
            var updated = await mediator.Send(new UpdateOneCommand<Vacation, VacationUpdate>(id, vacation));
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