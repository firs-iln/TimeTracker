using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Entities.Enums;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class EmployeePosition : BaseEntity
{
    public Employee Employee { get; set; } = null!;

    public required Guid EmployeeId { get; set; }

    public Position Position { get; set; } = null!;

    public required Guid PositionId { get; set; }

    public required DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? WorkSchedule { get; set; }

    public float? Salary { get; set; }

    public Department Department { get; set; } = null!;

    public required Guid DepartmentId { get; set; }
}