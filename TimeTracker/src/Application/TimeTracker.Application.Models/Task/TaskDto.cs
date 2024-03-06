using TimeTracker.Application.Models.Department;

namespace TimeTracker.Application.Models.Task;

public class TaskDto : Dto
{
    public required string Description { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime Deadline { get; set; }
    public required DepartmentDto Department { get; set; }
}