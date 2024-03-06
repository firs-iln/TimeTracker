using TimeTracker.Application.Models.Department;
using TimeTracker.Application.Models.Employee;
using TimeTracker.Application.Models.Position;

namespace TimeTracker.Application.Models.EmployeePosition;

public class UpdateEmployeePositionDto : Dto
{
    public required EmployeeDto Employee { get; set; }
    public required PositionDto Position { get; set; }
    public required DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string? WorkSchedule { get; set; }
    public float? Salary { get; set; }
    public required DepartmentDto Department { get; set; }
}