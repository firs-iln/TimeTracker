using TimeTracker.Application.Models.Abstractions;
using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Models;

public class Problem : BaseModel
{
    public required string Description { get; set; }

    public ProblemStatus Status { get; set; }

    public DateTime Deadline { get; set; }

    public required Guid DepartmentId { get; set; }
}