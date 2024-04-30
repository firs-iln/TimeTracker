using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class ProblemRecordEntity : BaseEntity
{
    public EmployeeEntity Employee { get; set; } = null!;

    public required Guid EmployeeId { get; set; }

    public ProblemEntity Problem { get; set; } = null!;

    public required Guid ProblemId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}