using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Models;

public class Position : BaseModel
{
    public required string Title { get; set; }

    public required string Description { get; set; }
}