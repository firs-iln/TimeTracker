namespace TimeTracker.Application.Models.Position;

public class CreatePositionDto : Dto
{
    public required string Title { get; set; }
    public required string Description { get; set; }
}