using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TaskStatus = TimeTracker.Infrastructure.Persistence.Entities.Enums.TaskStatus;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class Problem : BaseEntity
{
    public required string Description { get; set; }

    public TaskStatus Status { get; set; }

    public DateTime Deadline { get; set; }

    public required Department Department { get; set; }
}