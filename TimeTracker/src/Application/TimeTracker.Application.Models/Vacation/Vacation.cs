namespace TimeTracker.Application.Models.Vacation;

public class Vacation : Entity
{
    public required Employee.Employee Employee { get; set; }
    public required VacationType Type { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}