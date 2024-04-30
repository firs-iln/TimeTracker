using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Entities.Enums;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class EmployeePositionEntity : BaseEntity
{
    public EmployeeEntity Employee { get; set; } = null!;

    public required Guid EmployeeId { get; set; }

    public PositionEntity Position { get; set; } = null!;

    public required Guid PositionId { get; set; }

    public required DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? WorkSchedule { get; set; }

    public float? Salary { get; set; }

    public DepartmentEntity Department { get; set; } = null!;

    public required Guid DepartmentId { get; set; }
}