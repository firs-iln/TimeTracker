using time_tracker.Application.Contracts.Employee;

namespace time_tracker.Application.Contracts.Department;

public class DepartmentDto(Guid id, string name, EmployeeDto manager)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public EmployeeDto Manager { get; set; } = manager;
}