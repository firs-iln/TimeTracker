using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Contracts.Services.Department;

namespace TimeTracker.Presentation.Http.Controllers;

public class DepartmentController(IDepartmentService departmentService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var department = await departmentService.GetAsync(id);
        return Ok(department);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var departments = await departmentService.GetAllAsync();
        return Ok(departments);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] DepartmentCreate? department)
    {
        if (department == null)
        {
            return BadRequest();
        }

        var createdDepartment = await departmentService.CreateAsync(department);
        if (createdDepartment != null)
        {
            return CreatedAtAction("Get", new { id = createdDepartment.Id }, createdDepartment);
        }

        return BadRequest();
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] DepartmentUpdate? department)
    {
        if (department == null)
        {
            return BadRequest();
        }

        var updatedDepartment = await departmentService.UpdateAsync(id, department);
        if (updatedDepartment != null)
        {
            return Ok(updatedDepartment);
        }

        return BadRequest();
    }
}