using TimeTracker.Application.Models;

namespace TimeTracker.Application.Models.User;

public class UserDto : Dto
{
    public required string Username { get; set; }
    public required string HashedPassword { get; set; }
    public required UserRole Role { get; set; }
}