namespace TimeTracker.Application.Models.User;

public class User : Entity
{
    public required string Username { get; set; }

    public required string HashedPassword { get; set; }

    public required UserRole Role { get; set; }
}