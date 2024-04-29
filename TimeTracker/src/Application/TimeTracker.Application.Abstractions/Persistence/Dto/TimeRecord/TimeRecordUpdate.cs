namespace TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;

public class TimeRecordUpdate
{
    public Guid? EmployeeId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}