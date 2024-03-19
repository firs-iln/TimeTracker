namespace TimeTracker.Application.Models.Entites;

public class Employee : Entity
{
    public required User User { get; set; }

    public required string FullName { get; set; }

    public required string PassportData { get; set; }

    public required string PhoneNumber { get; set; }

    public required string Email { get; set; }

    public required DateOnly DateOfBirth { get; set; }
}