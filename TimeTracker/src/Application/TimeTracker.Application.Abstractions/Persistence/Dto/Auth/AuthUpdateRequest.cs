namespace TimeTracker.Application.Abstractions.Persistence.Dto.Auth;

public class AuthUpdateRequest
{
    public required string Refresh { get; set; }
}