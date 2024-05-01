using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Contracts.Services.TimeRecord;

namespace TimeTracker.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeRecordController(ITimeRecordService timeRecordService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var timeRecord = await timeRecordService.GetAsync(id);
        return Ok(timeRecord);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var timeRecords = await timeRecordService.GetAllAsync();
        return Ok(timeRecords);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] TimeRecordCreate? timeRecord)
    {
        if (timeRecord == null)
        {
            return BadRequest();
        }

        var createdTimeRecord = await timeRecordService.CreateAsync(timeRecord);
        if (createdTimeRecord != null)
        {
            return CreatedAtAction("Get", new { id = createdTimeRecord.Id }, createdTimeRecord);
        }

        return BadRequest();
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TimeRecordUpdate? timeRecord)
    {
        if (timeRecord == null)
        {
            return BadRequest();
        }

        var updatedTimeRecord = await timeRecordService.UpdateAsync(id, timeRecord);
        if (updatedTimeRecord != null)
        {
            return Ok(updatedTimeRecord);
        }

        return BadRequest();
    }
}