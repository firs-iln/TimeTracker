namespace Application.Models.EmployeePosition;

public class EmployeePosition
{
    public Guid id { get; set; }
    public Employee Employee { get; set; }
    public Position Position { get; set; }
    public Date StartDate { get; set; }
    public Date EndDate { get; set; }
    public string WorkSchedule { get; set; }
    public float Salary { get; set; }
    public Department Department { get; set; }

}