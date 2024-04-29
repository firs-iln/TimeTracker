namespace TimeTracker.Application.Abstractions.Persistence.Dto.Auth;

public class AuthUpdate
{
    public Guid? UserId { get; set; }

    public string? Refresh { get; set; }
}