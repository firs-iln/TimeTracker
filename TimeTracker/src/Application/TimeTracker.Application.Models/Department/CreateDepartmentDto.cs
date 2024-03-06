using TimeTracker.Application.Models.Employee;

namespace TimeTracker.Application.Models.Department;

public class CreateDepartmentDto : Dto
{
    public required string Name { get; set; }
    public required EmployeeDto Manager { get; set; }
}