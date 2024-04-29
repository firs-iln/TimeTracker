using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;

public class VacationCreate
{
    public required Guid EmployeeId { get; set; }

    public required VacationType Type { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}