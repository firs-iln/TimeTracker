using TimeTracker.Application.Models.Employee;

namespace TimeTracker.Application.Models.TimeRecord;

public class TimeRecordDto : Dto
{
    public required EmployeeDto Employee { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
}