namespace TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;

public class TimeRecordCreate
{
    public required Guid EmployeeId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}