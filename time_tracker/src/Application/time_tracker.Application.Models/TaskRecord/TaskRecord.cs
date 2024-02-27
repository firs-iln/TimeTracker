namespace Application.Models.TaskRecord;

public class TaskRecord
{
    public int Id { get; set; }
    public int Employeeid { get; set; }
    public int TaskId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
}