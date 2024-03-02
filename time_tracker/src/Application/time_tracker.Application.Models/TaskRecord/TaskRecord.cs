namespace Application.Models.TaskRecord;

public class TaskRecord
{
    public Guid Id { get; set; }
    public Employee Employee { get; set; }
    public Task Task { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
}