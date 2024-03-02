namespace Application.Models.Department;

public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Employee Manager { get; set; }
}

