using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(Department), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var department = await mediator.Send(new GetOneByIdQuery<Department>(id));
            return Ok(department);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Department>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsync()
    {
        var departments = await mediator.Send(new GetAllQuery<Department>());
        return Ok(departments);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Department), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> CreateAsync([FromBody] DepartmentCreate? department)
    {
        if (department == null)
        {
            return BadRequest();
        }

        try
        {
            var created = await mediator.Send(new CreateOneCommand<Department, DepartmentCreate>(department));
            return CreatedAtAction("Get", new { id = created.Id }, created);
        }
        catch (UnprocessableEntityException)
        {
            return BadRequest();
        }
    }
    
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(Department), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] DepartmentUpdate? department)
    {
        if (department == null)
        {
            return BadRequest();
        }

        try
        {
            var updated = await mediator.Send(new UpdateOneCommand<Department, DepartmentUpdate>(id, department));
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