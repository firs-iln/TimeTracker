using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class Vacation : Entity
{
    public required Employee Employee { get; set; }

    public required VacationType Type { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}