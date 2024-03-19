namespace TimeTracker.Application.Models.Entites;

public class User : Entity
{
    public required string Username { get; set; }

    public required string HashedPassword { get; set; }

    public required UserRole Role { get; set; }
}