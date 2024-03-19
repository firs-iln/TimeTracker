using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class Employee : Entity
{
    public required User User { get; set; }

    public required string FullName { get; set; }

    public required string PassportData { get; set; }

    public required string PhoneNumber { get; set; }

    public required string Email { get; set; }

    public required DateOnly DateOfBirth { get; set; }
}