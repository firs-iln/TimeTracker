namespace time_tracker.Application.Models.User;

public class UpdateUserDto
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? HashedPassword { get; set; }
    public UserRole? Role { get; set; }
}