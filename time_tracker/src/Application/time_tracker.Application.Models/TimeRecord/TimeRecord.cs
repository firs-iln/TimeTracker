namespace Application.Models.TimeRecord;

public class TimeRecord
{
    public Guid Id { get; set; }
    public Employee Employee { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
}