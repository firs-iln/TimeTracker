using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Models;

public class ProblemRecord : BaseModel
{
    public required Guid EmployeeId { get; set; }

    public required Guid ProblemId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}