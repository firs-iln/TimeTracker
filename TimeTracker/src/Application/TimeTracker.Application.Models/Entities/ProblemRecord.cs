using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class ProblemRecord : Entity
{
    public required Employee Employee { get; set; }

    public required Problem Problem { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}