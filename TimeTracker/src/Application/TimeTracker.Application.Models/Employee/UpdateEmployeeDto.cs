namespace TimeTracker.Application.Models.Employee;

public class UpdateEmployeeDto : Dto
{
    public string? FullName { get; set; }
    public string? PassportData { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public DateOnly? DateOfBirth { get; set; }

}