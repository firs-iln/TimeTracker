using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Entities.Enums;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class Department : BaseEntity
{
    public required string Name { get; set; }

    public Employee Manager { get; set; } = null!;

    public required Guid ManagerId { get; set; }
}