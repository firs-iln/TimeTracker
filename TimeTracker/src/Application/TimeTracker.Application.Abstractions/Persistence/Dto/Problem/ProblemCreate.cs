using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Abstractions.Persistence.Dto.Problem;

public class ProblemCreate
{
    public required string Description { get; set; }

    public ProblemStatus Status { get; set; }

    public DateTime Deadline { get; set; }

    public required Guid DepartmentId { get; set; }
}