namespace Application.Models.Task;

public class Task
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime Deadline { get; set; }
    public Department Department { get; set; }
}