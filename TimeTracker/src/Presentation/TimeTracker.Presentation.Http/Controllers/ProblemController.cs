using Microsoft.AspNetCore.Mvc;
using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Contracts.Services.Problem;

namespace TimeTracker.Presentation.Http.Controllers;

public class ProblemController(IProblemService problemService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var problem = await problemService.GetAsync(id);
        return Ok(problem);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var problems = await problemService.GetAllAsync();
        return Ok(problems);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] ProblemCreate? problem)
    {
        if (problem == null)
        {
            return BadRequest();
        }

        var createdProblem = await problemService.CreateAsync(problem);
        if (createdProblem != null)
        {
            return CreatedAtAction("Get", new { id = createdProblem.Id }, createdProblem);
        }

        return BadRequest();
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] ProblemUpdate? problem)
    {
        if (problem == null)
        {
            return BadRequest();
        }

        var updatedProblem = await problemService.UpdateAsync(id, problem);
        if (updatedProblem != null)
        {
            return Ok(updatedProblem);
        }

        return BadRequest();
    }
}