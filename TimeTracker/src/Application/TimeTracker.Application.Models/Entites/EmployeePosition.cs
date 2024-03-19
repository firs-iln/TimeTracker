namespace TimeTracker.Application.Models.Entites;

public class EmployeePosition : Entity
{
    public required Employee Employee { get; set; }

    public required Position Position { get; set; }

    public required DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? WorkSchedule { get; set; }

    public float? Salary { get; set; }

    public required Department Department { get; set; }
}