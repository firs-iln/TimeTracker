namespace TimeTracker.Application.Models.TimeRecord;

public class TimeRecord : Entity
{
    public required Employee.Employee Employee { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}