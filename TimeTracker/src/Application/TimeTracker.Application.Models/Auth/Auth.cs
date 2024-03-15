namespace TimeTracker.Application.Models.Auth;

public class Auth
{
    public required User.User User { get; set; }

    public required string Access { get; set; }

    public required string Refresh { get; set; }
}