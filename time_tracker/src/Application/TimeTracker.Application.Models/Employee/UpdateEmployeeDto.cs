namespace time_tracker.Application.Contracts.Employee;

public class UpdateEmployeeDto
{
    public Guid id { get; set; }
    public string? FullName { get; set; }
    public string? PassportData { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public DateOnly DateOfBirth { get; set; }

}