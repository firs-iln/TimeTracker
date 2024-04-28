using TimeTracker.Application.Models.Abstractions;
using TimeTracker.Application.Models.Enums;

namespace TimeTracker.Application.Models;

public class Vacation : BaseModel
{
    public required Guid EmployeeId { get; set; }

    public required VacationType Type { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}