using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class DepartmentEntity : BaseEntity
{
    public required string Name { get; set; }

    public EmployeeEntity Manager { get; set; } = null!;

    public required Guid ManagerId { get; set; }
}