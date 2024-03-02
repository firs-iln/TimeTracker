using time_tracker.Application.Contracts.Department;

namespace time_tracker.Application.Models.Task;

public class Task
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime Deadline { get; set; }
    public required DepartmentDto Department { get; set; }
}