namespace TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;

public class ProblemRecordCreate
{
    public required Guid EmployeeId { get; set; }

    public required Guid ProblemId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}