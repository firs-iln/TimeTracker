namespace time_tracker.Application.Models.User;

public class UserDto
{
    public required Guid Id { get; set; }
    public required string Username { get; set; }
    public required string HashedPassword { get; set; }
    public required UserRole Role { get; set; }
}