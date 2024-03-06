using time_tracker.Application.Contracts.Employee;

namespace time_tracker.Application.Contracts.Department;
    
public class UpdateEmployeeDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public EmployeeDto? Manager { get; set; }
}