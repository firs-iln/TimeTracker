namespace Application.Models.EmployeePosition;

public class EmployeePosition
{
    public int id { get; set; }
    public int EmployeeId { get; set; }
    public int PositionId { get; set; }
    public Date StartDate { get; set; }
    public Date EndDate { get; set; }
    public string WorkSchedule { get; set; }
    public float Salary { get; set; }
}