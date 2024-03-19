using TimeTracker.Application.Models.Entities.Abstractions;
using TaskStatus = TimeTracker.Application.Models.Entities.Enums.TaskStatus;

namespace TimeTracker.Application.Models.Entities;

public class Problem : Entity
{
    public required string Description { get; set; }

    public TaskStatus Status { get; set; }

    public DateTime Deadline { get; set; }

    public required Department Department { get; set; }
}