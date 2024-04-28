using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Models;

public class EmployeePosition : BaseModel
{
    public required Guid EmployeeId { get; set; }

    public required Guid PositionId { get; set; }

    public required DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? WorkSchedule { get; set; }

    public float? Salary { get; set; }

    public required Guid DepartmentId { get; set; }
}