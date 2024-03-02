namespace time_tracker.Application.Models.Position;

public class Position
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
}