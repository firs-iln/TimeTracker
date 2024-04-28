using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class TimeRecord : BaseEntity
{
    public required Employee Employee { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}