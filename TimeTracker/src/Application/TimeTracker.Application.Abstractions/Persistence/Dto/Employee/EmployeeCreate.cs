namespace TimeTracker.Application.Abstractions.Persistence.Dto.Employee;

public class EmployeeCreate
{
    public required Guid UserId { get; set; }

    public required string FullName { get; set; }

    public required string PassportData { get; set; }

    public required string PhoneNumber { get; set; }

    public required string Email { get; set; }

    public required DateOnly DateOfBirth { get; set; }
}