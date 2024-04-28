using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Entities.Enums;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class User : BaseEntity
{
    public required string Username { get; set; }

    public required string HashedPassword { get; set; }

    public required UserRole Role { get; set; }
}