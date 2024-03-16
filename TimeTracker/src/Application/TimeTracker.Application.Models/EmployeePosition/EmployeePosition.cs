using System;

namespace TimeTracker.Application.Models.EmployeePosition;

public class EmployeePosition : Entity
{
    public required Employee.Employee Employee { get; set; }

    public required Position.Position Position { get; set; }

    public required DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? WorkSchedule { get; set; }

    public float? Salary { get; set; }

    public required Department.Department Department { get; set; }
}