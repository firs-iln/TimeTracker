namespace TimeTracker.Application.Abstractions.Persistence.Dto.Position;

public class PositionCreate
{
    public required string Title { get; set; }

    public required string Description { get; set; }
}