using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class Position : Entity
{
    public required string Title { get; set; }

    public required string Description { get; set; }
}