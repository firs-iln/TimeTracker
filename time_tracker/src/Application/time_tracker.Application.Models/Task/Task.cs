namespace Application.Models.Task;

public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime Deadline { get; set; }
    public int DepartmentId { get; set; }
}