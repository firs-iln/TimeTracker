using TimeTracker.Application.Models.User;

namespace TimeTracker.Application.Models.Employee;

public class EmployeeDto : Dto
{
    public required UserDto User { get; set; }
    public required string FullName { get; set; }
    public required string PassportData { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Email { get; set; }
    public required DateOnly DateOfBirth { get; set; }
}