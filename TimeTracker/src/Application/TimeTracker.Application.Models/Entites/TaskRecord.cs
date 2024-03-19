namespace TimeTracker.Application.Models.Entites;

public class TaskRecord : Entity
{
    public required Employee Employee { get; set; }

    public required Entites.Task Task { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}