using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;

public class VacationUpdate
{
    public Guid? EmployeeId { get; set; }

    public VacationType? Type { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
}