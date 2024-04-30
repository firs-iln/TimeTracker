using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Contracts.Services.ProblemRecord;

namespace TimeTracker.Presentation.Http.Controllers;

public class ProblemRecordController(IProblemRecordService problemRecordService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var problemRecord = await problemRecordService.GetAsync(id);
        return Ok(problemRecord);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var problemRecords = await problemRecordService.GetAllAsync();
        return Ok(problemRecords);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] ProblemRecordCreate? problemRecord)
    {
        if (problemRecord == null)
        {
            return BadRequest();
        }

        var createdProblemRecord = await problemRecordService.CreateAsync(problemRecord);
        if (createdProblemRecord != null)
        {
            return CreatedAtAction("Get", new { id = createdProblemRecord.Id }, createdProblemRecord);
        }

        return BadRequest();
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] ProblemRecordUpdate? problemRecord)
    {
        if (problemRecord == null)
        {
            return BadRequest();
        }

        var updatedProblemRecord = await problemRecordService.UpdateAsync(id, problemRecord);
        if (updatedProblemRecord != null)
        {
            return Ok(updatedProblemRecord);
        }

        return BadRequest();
    }
}