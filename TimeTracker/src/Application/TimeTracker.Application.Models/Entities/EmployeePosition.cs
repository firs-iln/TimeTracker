using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class EmployeePosition : Entity
{
    public required Employee Employee { get; set; }

    public required Position Position { get; set; }

    public required DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? WorkSchedule { get; set; }

    public float? Salary { get; set; }

    public required Department Department { get; set; }
}