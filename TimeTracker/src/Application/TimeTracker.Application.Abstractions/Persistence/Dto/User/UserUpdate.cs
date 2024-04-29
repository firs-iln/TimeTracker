using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Abstractions.Persistence.Dto.User;

public class UserUpdate
{
    public string? Username { get; set; }

    public string? HashedPassword { get; set; }

    public UserRole? Role { get; set; }
}