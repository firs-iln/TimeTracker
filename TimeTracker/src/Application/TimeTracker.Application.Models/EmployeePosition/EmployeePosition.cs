using TimeTracker.Application.Models.Department;
using TimeTracker.Application.Models.Employee;

namespace TimeTracker.Application.Models.EmployeePosition;

public class EmployeePositionDto : Dto
{
    public required EmployeeDto Employee { get; set; }
    public required Position.PositionDto Position { get; set; }
    public required DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string? WorkSchedule { get; set; }
    public float? Salary { get; set; }
    public required DepartmentDto Department { get; set; }
}