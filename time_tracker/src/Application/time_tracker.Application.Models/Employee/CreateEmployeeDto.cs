using time_tracker.Application.Models.User;

namespace time_tracker.Application.Contracts.Employee;

public class CreateEmployeeDto(UserDto user, string fullName, string passportData, string phoneNumber, string email, DateOnly dateOfBirth)
{
    public UserDto User { get; set; } = user;
    public string FullName { get; set; } = fullName;
    public string PassportData { get; set; } = passportData;
    public string PhoneNumber { get; set; } = phoneNumber;
    public string Email { get; set; } = email;
    public DateOnly DateOfBirth { get; set; } = dateOfBirth;
}