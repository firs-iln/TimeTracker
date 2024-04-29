namespace TimeTracker.Application.Abstractions.Persistence.Dto.Department;

public class DepartmentUpdate
{
    public string? Name { get; set; }

    public Guid? ManagerId { get; set; }
}