using TimeTracker.Application.Models.Employee;

namespace TimeTracker.Application.Models.Vacation;

public class VacationDto : Dto
{
    public required EmployeeDto Employee { get; set; }
    public required VacationType Type { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}