namespace Application.Models.TimeRecord;

public class TimeRecord
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
}