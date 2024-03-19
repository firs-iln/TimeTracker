namespace TimeTracker.Application.Models.Entites;

public class TimeRecord : Entity
{
    public required Employee Employee { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}