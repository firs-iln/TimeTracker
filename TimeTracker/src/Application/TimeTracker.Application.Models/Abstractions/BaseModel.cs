namespace TimeTracker.Application.Models.Abstractions;

public abstract class BaseModel
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}