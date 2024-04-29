using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Abstractions.Persistence.Dto.User;

public class UserCreate
{
    public required string Username { get; set; }

    public required string HashedPassword { get; set; }

    public required UserRole Role { get; set; }
}