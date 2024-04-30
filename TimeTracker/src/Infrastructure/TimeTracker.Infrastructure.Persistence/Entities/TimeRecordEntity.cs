using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class TimeRecordEntity : BaseEntity
{
    public EmployeeEntity Employee { get; set; } = null!;

    public required Guid EmployeeId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}