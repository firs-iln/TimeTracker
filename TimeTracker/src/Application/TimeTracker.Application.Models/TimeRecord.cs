using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Models;

public class TimeRecord : BaseModel
{
    public required Guid EmployeeId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}