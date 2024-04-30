using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Contracts.Services.Vacation;

namespace TimeTracker.Presentation.Http.Controllers;

public class VacationController(IVacationService vacationService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var vacation = await vacationService.GetAsync(id);
        return Ok(vacation);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var vacations = await vacationService.GetAllAsync();
        return Ok(vacations);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] VacationCreate? vacation)
    {
        if (vacation == null)
        {
            return BadRequest();
        }

        var createdVacation = await vacationService.CreateAsync(vacation);
        if (createdVacation != null)
        {
            return CreatedAtAction("Get", new { id = createdVacation.Id }, createdVacation);
        }

        return BadRequest();
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] VacationUpdate? vacation)
    {
        if (vacation == null)
        {
            return BadRequest();
        }

        var updatedVacation = await vacationService.UpdateAsync(id, vacation);
        if (updatedVacation != null)
        {
            return Ok(updatedVacation);
        }

        return BadRequest();
    }
}