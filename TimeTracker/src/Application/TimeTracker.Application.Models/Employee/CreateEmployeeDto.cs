using TimeTracker.Application.Models.User;

namespace TimeTracker.Application.Models.Employee;

public class CreateEmployeeDto : Dto
{
    public required UserDto User { get; set; }
    public required string FullName { get; set; }
    public string? PassportData { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public DateOnly? DateOfBirth { get; set; }
}