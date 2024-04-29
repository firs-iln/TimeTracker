namespace TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;

public class EmployeePositionUpdate
{
    public Guid? EmployeeId { get; set; }

    public Guid? PositionId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? WorkSchedule { get; set; }

    public float? Salary { get; set; }

    public Guid? DepartmentId { get; set; }
}