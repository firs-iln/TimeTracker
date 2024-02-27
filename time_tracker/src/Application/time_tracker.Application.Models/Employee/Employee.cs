namespace Application.Models.Employee;

public class Employee
{
    public string id { get; set; }
    public int UserId { get; set; }
    public string FullName { get; set; }
    public string PassportData { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Date DateOfBirth { get; set; }
}