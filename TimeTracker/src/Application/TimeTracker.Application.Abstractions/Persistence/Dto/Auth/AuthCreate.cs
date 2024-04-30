namespace TimeTracker.Application.Abstractions.Persistence.Dto.Auth;

public class AuthCreate
{
    public required Guid UserId { get; set; }

    public required string Refresh { get; set; }

    public required string Access { get; set; }
}