using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Models;

public class Department : BaseModel
{
    public required string Name { get; set; }

    public required Guid ManagerId { get; set; }
}