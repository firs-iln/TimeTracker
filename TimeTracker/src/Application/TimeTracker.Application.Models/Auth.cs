using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Models;

public class Auth : BaseModel
{
    public required Guid UserId { get; set; }

    public required string Refresh { get; set; }

    public required string Access { get; set; }
}