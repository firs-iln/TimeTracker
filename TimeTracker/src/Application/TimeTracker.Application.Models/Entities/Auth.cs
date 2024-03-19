using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class Auth : Entity
{
    public required User User { get; set; }

    public required string Access { get; set; }

    public required string Refresh { get; set; }
}