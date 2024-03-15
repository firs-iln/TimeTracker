namespace TimeTracker.Application.Models.TaskRecord;

public class TaskRecord : Entity
{
    public required Employee.Employee Employee { get; set; }

    public required Task.Task Task { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}