namespace TimeTracker.Application.Abstractions.Persistence.Dto.Employee;

public class EmployeeUpdate
{
    public Guid? UserId { get; set; }

    public string? FullName { get; set; }

    public string? PassportData { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }
}