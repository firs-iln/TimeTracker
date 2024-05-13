using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Events.Commands;
using TimeTracker.Application.Events.Queries;
using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Exceptions;
using TimeTracker.Application.Models;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [Authorize]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var employee = await mediator.Send(new GetOneByIdQuery<Employee>(id));
            return Ok(employee);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Employee>), (int)HttpStatusCode.OK)]
    [Authorize]
    public async Task<IActionResult> GetAllAsync()
    {
        var employees = await mediator.Send(new GetAllQuery<Employee>());
        return Ok(employees);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [Authorize]
    public async Task<IActionResult> CreateAsync([FromBody] EmployeeCreate? employee)
    {
        if (employee == null)
        {
            return BadRequest();
        }

        try
        {
            var created = await mediator.Send(new CreateOneCommand<Employee, EmployeeCreate>(employee));
            return CreatedAtAction("Get", new { id = created.Id }, created);
        }
        catch (UnprocessableEntityException)
        {
            return BadRequest();
        }
    }
    
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [Authorize]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] EmployeeUpdate? employee)
    {
        if (employee == null)
        {
            return BadRequest();
        }

        try
        {
            var updated = await mediator.Send(new UpdateOneCommand<Employee, EmployeeUpdate>(id, employee));
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