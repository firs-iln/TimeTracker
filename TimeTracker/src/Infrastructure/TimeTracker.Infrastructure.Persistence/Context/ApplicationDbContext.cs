using Microsoft.EntityFrameworkCore;
using TimeTracker.Infrastructure.Persistence.Entities;
using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

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

    public override int SaveChanges()
    {
        AddTimestamps();
        return base.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        AddTimestamps();
        return await base.SaveChangesAsync();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Сюда добавлять различные конфигурации ваших файлов
        base.OnModelCreating(modelBuilder);
    }

    private void AddTimestamps()
    {
        var entities = ChangeTracker.Entries()
            .Where(x => x is { Entity: BaseEntity, State: EntityState.Added or EntityState.Modified });

        foreach (var entity in entities)
        {
            var now = DateTime.UtcNow; // current datetime

            if (entity.State == EntityState.Added)
            {
                ((BaseEntity)entity.Entity).CreatedAt = now;
            }

            ((BaseEntity)entity.Entity).UpdatedAt = now;
        }
    }
}