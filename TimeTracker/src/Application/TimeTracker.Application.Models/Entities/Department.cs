using TimeTracker.Application.Models.Entities.Abstractions;

namespace TimeTracker.Application.Models.Entities;

public class Department : Entity
{
    public required string Name { get; set; }

    public required Employee Manager { get; set; }
}