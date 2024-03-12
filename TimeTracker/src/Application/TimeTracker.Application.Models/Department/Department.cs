namespace TimeTracker.Application.Models.Department;

public class Department : Entity
{
    public required string Name { get; set; }
    public required Employee.Employee Manager { get; set; }
}