using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Contracts.Services.Position;

namespace TimeTracker.Presentation.Http.Controllers;

public class PositionController(IPositionService positionService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var position = await positionService.GetAsync(id);
        return Ok(position);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var positions = await positionService.GetAllAsync();
        return Ok(positions);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] PositionCreate? position)
    {
        if (position == null)
        {
            return BadRequest();
        }

        var createdPosition = await positionService.CreateAsync(position);
        if (createdPosition != null)
        {
            return CreatedAtAction("Get", new { id = createdPosition.Id }, createdPosition);
        }

        return BadRequest();
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] PositionUpdate? position)
    {
        if (position == null)
        {
            return BadRequest();
        }

        var updatedPosition = await positionService.UpdateAsync(id, position);
        if (updatedPosition != null)
        {
            return Ok(updatedPosition);
        }

        return BadRequest();
    }
}