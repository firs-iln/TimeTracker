using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Entities.Enums;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class ProblemEntity : BaseEntity
{
    public required string Description { get; set; }

    public ProblemStatus Status { get; set; }

    public DateTime Deadline { get; set; }

    public DepartmentEntity Department { get; set; } = null!;

    public required Guid DepartmentId { get; set; }
}