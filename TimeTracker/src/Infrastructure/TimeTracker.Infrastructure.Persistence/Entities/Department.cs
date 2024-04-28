using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Entities.Enums;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class Department : BaseEntity
{
    public required string Name { get; set; }

    public required Employee Manager { get; set; }
}