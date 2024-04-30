using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Entities;

public class EmployeeEntity : BaseEntity
{
    public UserEntity User { get; set; } = null!;

    public required Guid UserId { get; set; }

    public required string FullName { get; set; }

    public required string PassportData { get; set; }

    public required string PhoneNumber { get; set; }

    public required string Email { get; set; }

    public required DateOnly DateOfBirth { get; set; }
}