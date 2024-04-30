namespace TimeTracker.Application.Abstractions.Persistence.Dto.Auth;

public class AuthenticateRequest
{
    public required string Username { get; set; }
    
    public required string HashedPassword { get; set; }
}