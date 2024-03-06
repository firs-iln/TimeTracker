using TimeTracker.Application.Models;

namespace TimeTracker.Application.Models.User;

public class UpdateUserDto : Dto
{
    public string? Username { get; set; }
    public string? HashedPassword { get; set; }
    public UserRole? Role { get; set; }
}