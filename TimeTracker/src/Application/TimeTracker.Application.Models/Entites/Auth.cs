namespace TimeTracker.Application.Models.Entites;

public class Auth
{
    public required Entites.User User { get; set; }

    public required string Access { get; set; }

    public required string Refresh { get; set; }
}