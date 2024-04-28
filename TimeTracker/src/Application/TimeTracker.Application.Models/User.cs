using TimeTracker.Application.Models.Abstractions;
using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Models;

public class User : BaseModel
{
    public required string Username { get; set; }

    public required string HashedPassword { get; set; }

    public required UserRole Role { get; set; }
}