namespace TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;

public class ProblemRecordUpdate
{
    public Guid? EmployeeId { get; set; }

    public Guid? ProblemId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}