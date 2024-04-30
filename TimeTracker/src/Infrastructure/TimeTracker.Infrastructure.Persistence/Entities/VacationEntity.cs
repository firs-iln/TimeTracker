using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Entities.Enums;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class VacationEntity : BaseEntity
{
    public EmployeeEntity Employee { get; set; } = null!;

    public required Guid EmployeeId { get; set; }

    public required VacationType Type { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}