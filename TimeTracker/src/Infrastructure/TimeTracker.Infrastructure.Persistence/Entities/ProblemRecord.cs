using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class ProblemRecord : BaseEntity
{
    public required Employee Employee { get; set; }

    public required Problem Problem { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}