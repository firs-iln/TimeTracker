using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeRecordController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(TimeRecord), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [Authorize]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var timeRecord = await mediator.Send(new GetOneByIdQuery<TimeRecord>(id));
            return Ok(timeRecord);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<TimeRecord>), (int)HttpStatusCode.OK)]
    [Authorize]
    public async Task<IActionResult> GetAllAsync()
    {
        var timeRecords = await mediator.Send(new GetAllQuery<TimeRecord>());
        return Ok(timeRecords);
    }

    [HttpPost]
    [ProducesResponseType(typeof(TimeRecord), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [Authorize]
    public async Task<IActionResult> CreateAsync([FromBody] TimeRecordCreate? timeRecord)
    {
        if (timeRecord == null)
        {
            return BadRequest();
        }

        try
        {
            var created = await mediator.Send(new CreateOneCommand<TimeRecord, TimeRecordCreate>(timeRecord));
            return CreatedAtAction("Get", new { id = created.Id }, created);
        }
        catch (UnprocessableEntityException)
        {
            return BadRequest();
        }
    }
    
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(TimeRecord), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [Authorize]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TimeRecordUpdate? timeRecord)
    {
        if (timeRecord == null)
        {
            return BadRequest();
        }

        try
        {
            var updated = await mediator.Send(new UpdateOneCommand<TimeRecord, TimeRecordUpdate>(id, timeRecord));
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