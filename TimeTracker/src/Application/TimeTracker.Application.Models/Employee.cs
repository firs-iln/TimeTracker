using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Models;

public class Employee : BaseModel
{
    public required Guid UserId { get; set; }

    public required string FullName { get; set; }

    public required string PassportData { get; set; }

    public required string PhoneNumber { get; set; }

    public required string Email { get; set; }

    public required DateOnly DateOfBirth { get; set; }
}