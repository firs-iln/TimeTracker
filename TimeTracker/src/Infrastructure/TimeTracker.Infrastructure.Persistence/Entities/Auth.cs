using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class Auth : BaseEntity
{
    public User User { get; set; } = null!;

    public required Guid UserId { get; set; }

    public required string Refresh { get; set; }
}