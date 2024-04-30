using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Contracts.Services.Employee;

namespace TimeTracker.Presentation.Http.Controllers;

public class EmployeeController(IEmployeeService employeeService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var employee = await employeeService.GetAsync(id);
        return Ok(employee);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var employees = await employeeService.GetAllAsync();
        return Ok(employees);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] EmployeeCreate? employee)
    {
        if (employee == null)
        {
            return BadRequest();
        }

        var createdEmployee = await employeeService.CreateAsync(employee);
        if (createdEmployee != null)
        {
            return CreatedAtAction("Get", new { id = createdEmployee.Id }, createdEmployee);
        }

        return BadRequest();
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] EmployeeUpdate? employee)
    {
        if (employee == null)
        {
            return BadRequest();
        }

        var updatedEmployee = await employeeService.UpdateAsync(id, employee);
        if (updatedEmployee != null)
        {
            return Ok(updatedEmployee);
        }

        return BadRequest();
    }
}