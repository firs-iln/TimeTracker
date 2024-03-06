using TimeTracker.Application.Models.Department;

namespace TimeTracker.Application.Models.Task;

public class UpdateTaskDto : Dto
{
    public string? Description { get; set; }
    public TaskStatus? Status { get; set; }
    public DateTime? Deadline { get; set; }
    public DepartmentDto? Department { get; set; }
}