using Microsoft.EntityFrameworkCore;
using TimeTracker.Infrastructure.Persistence.Entities;

namespace TimeTracker.Infrastructure.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }

    public required DbSet<Auth> Auths { get; set; }

    public required DbSet<Department> Departments { get; set; }

    public required DbSet<Employee> Employees { get; set; }

    public required DbSet<EmployeePosition> EmployeePositions { get; set; }

    public required DbSet<Position> Positions { get; set; }

    public required DbSet<Problem> Problems { get; set; }

    public required DbSet<ProblemRecord> ProblemRecords { get; set; }

    public required DbSet<User> Users { get; set; }

    public required DbSet<Vacation> Vacations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Сюда добавлять различные конфигурации ваших файлов
        base.OnModelCreating(modelBuilder);
    }
}