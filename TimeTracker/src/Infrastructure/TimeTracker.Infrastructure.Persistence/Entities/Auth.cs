using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class Auth : BaseEntity
{
    public required User User { get; set; }

    public required string Refresh { get; set; }
}