using time_tracker.Application.Contracts.Employee;

namespace time_tracker.Application.Models.TimeRecord;

public class TimeRecord
{
    public Guid Id { get; set; }
    public required EmployeeDto Employee { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    
}