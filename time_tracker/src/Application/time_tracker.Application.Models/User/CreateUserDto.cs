namespace time_tracker.Application.Models.User;

public class CreateUserDto
{
    public required string Username{ get; set; }
    public required string HashedPassword { get; set; }
    public required UserRole Role { get; set; }
}