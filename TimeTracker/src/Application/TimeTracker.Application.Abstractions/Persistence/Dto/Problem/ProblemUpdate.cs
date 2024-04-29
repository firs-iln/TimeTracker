using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Abstractions.Persistence.Dto.Problem;

public class ProblemUpdate
{
    public string? Description { get; set; }

    public ProblemStatus? Status { get; set; }

    public DateTime? Deadline { get; set; }

    public Guid? DepartmentId { get; set; }
}