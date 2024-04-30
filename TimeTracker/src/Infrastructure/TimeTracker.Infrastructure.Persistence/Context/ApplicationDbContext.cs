using Microsoft.EntityFrameworkCore;
using TimeTracker.Infrastructure.Persistence.Entities;

namespace TimeTracker.Infrastructure.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }

    public required DbSet<AuthEntity> Auths { get; set; }

    public required DbSet<DepartmentEntity> Departments { get; set; }

    public required DbSet<EmployeeEntity> Employees { get; set; }

    public required DbSet<EmployeePositionEntity> EmployeePositions { get; set; }

    public required DbSet<PositionEntity> Positions { get; set; }

    public required DbSet<ProblemEntity> Problems { get; set; }

    public required DbSet<ProblemRecordEntity> ProblemRecords { get; set; }

    public required DbSet<UserEntity> Users { get; set; }

    public required DbSet<VacationEntity> Vacations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Сюда добавлять различные конфигурации ваших файлов
        base.OnModelCreating(modelBuilder);
    }
}