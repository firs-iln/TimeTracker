using TimeTracker.Application.Models.Employee;
using TimeTracker.Application.Models.Task;

namespace TimeTracker.Application.Models.TaskRecord;

public class CreateTaskRecord
{
    public required EmployeeDto Employee { get; set; }
    public required TaskDto Task { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
}