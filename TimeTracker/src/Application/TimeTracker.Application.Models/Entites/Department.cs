namespace TimeTracker.Application.Models.Entites;

public class Department : Entity
{
    public required string Name { get; set; }

    public required Employee Manager { get; set; }
}