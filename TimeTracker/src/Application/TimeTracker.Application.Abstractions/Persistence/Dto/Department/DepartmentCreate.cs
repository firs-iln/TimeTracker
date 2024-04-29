namespace TimeTracker.Application.Abstractions.Persistence.Dto.Department;

public class DepartmentCreate
{
    public required string Name { get; set; }

    public required Guid ManagerId { get; set; }
}