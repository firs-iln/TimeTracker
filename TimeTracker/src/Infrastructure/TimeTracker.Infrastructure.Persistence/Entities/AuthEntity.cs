using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class AuthEntity : BaseEntity
{
    public UserEntity User { get; set; } = null!;

    public required Guid UserId { get; set; }

    public required string Refresh { get; set; }

    public required string Access { get; set; }
}