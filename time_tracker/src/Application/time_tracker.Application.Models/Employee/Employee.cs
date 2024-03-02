namespace Application.Models.Employee;

public class Employee
{
    public Guid id { get; set; }
    public User User { get; set; }
    public string FullName { get; set; }
    public string PassportData { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Date DateOfBirth { get; set; }
}