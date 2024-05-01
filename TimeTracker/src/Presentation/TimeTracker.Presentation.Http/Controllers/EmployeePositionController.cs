using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;
using TimeTracker.Application.Contracts.Services.Employee;
using TimeTracker.Application.Contracts.Services.EmployeePosition;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeePositionController(IEmployeePositionService employeePositionService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var employeePosition = await employeePositionService.GetAsync(id);
        return Ok(employeePosition);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var employeePositions = await employeePositionService.GetAllAsync();
        return Ok(employeePositions);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] EmployeePositionCreate? employeePosition)
    {
        if (employeePosition == null)
        {
            return BadRequest();
        }

        var createdEmployeePosition = await employeePositionService.CreateAsync(employeePosition);
        if (createdEmployeePosition != null)
        {
            return CreatedAtAction("Get", new { id = createdEmployeePosition.Id }, createdEmployeePosition);
        }

        return BadRequest();
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] EmployeePositionUpdate? employeePosition)
    {
        if (employeePosition == null)
        {
            return BadRequest();
        }

        var updatedEmployeePosition = await employeePositionService.UpdateAsync(id, employeePosition);
        if (updatedEmployeePosition != null)
        {
            return Ok(updatedEmployeePosition);
        }

        return BadRequest();
    }
}