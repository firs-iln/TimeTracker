using TimeTracker.Application.Models.Employee;

namespace TimeTracker.Application.Models.Department;
    
public class UpdateDepartmentDto : Dto
{
    public string? Name { get; set; }
    public EmployeeDto? Manager { get; set; }
}