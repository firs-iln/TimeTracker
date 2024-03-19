using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class TimeRecord : Entity
{
    public required Employee Employee { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}