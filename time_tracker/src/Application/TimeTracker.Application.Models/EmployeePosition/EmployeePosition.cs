using time_tracker.Application.Contracts.Department;
using time_tracker.Application.Contracts.Employee;

namespace time_tracker.Application.Models.EmployeePosition;

public class EmployeePositionDto
{
    public Guid Id { get; set; }
    public required EmployeeDto Employee { get; set; }
    public required Position.Position Position { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }
    public string? WorkSchedule { get; set; }
    public float? Salary { get; set; }
    public required DepartmentDto Department { get; set; }

}