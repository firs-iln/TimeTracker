using TimeTracker.Application.Models.Employee;
using TimeTracker.Application.Models.Task;

namespace TimeTracker.Application.Models.TaskRecord;

public class UpdateTaskRecordDto : Dto
{
    public EmployeeDto? Employee { get; set; }
    public TaskDto? Task { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
}