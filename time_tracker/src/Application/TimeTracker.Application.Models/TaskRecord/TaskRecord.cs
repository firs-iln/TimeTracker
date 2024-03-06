using time_tracker.Application.Contracts.Employee;

namespace time_tracker.Application.Models.TaskRecord;

public class TaskRecord
{
    public Guid Id { get; set; }
    public required EmployeeDto Employee { get; set; }
    public required Task.Task Task { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
}