using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class PositionEntity : BaseEntity
{
    public required string Title { get; set; }

    public required string Description { get; set; }
}