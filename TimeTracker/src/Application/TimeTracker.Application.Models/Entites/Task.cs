namespace TimeTracker.Application.Models.Entites;

public class Task : Entity
{
    public required string Description { get; set; }

    public TaskStatus Status { get; set; }

    public DateTime Deadline { get; set; }

    public required Department Department { get; set; }
}