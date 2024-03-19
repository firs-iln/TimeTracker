using TimeTracker.Application.Models.Entities.Abstractions;
using TimeTracker.Application.Models.Entities.Enums;

namespace TimeTracker.Application.Models.Entities;

public class User : Entity
{
    public required string Username { get; set; }

    public required string HashedPassword { get; set; }

    public required UserRole Role { get; set; }
}