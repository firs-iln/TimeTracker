using time_tracker.Application.Contracts.Employee;

namespace time_tracker.Application.Models.Vacation;

public class Vacation
{
    public Guid Id { get; set; }
    public required EmployeeDto Employee { get; set; }
    public required VacationType Type { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}