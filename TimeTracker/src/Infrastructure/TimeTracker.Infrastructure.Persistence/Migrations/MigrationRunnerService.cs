using Itmo.Dev.Platform.Postgres.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Task = System.Threading.Tasks.Task;

namespace TimeTracker.Infrastructure.Persistence.Migrations;

/// <summary>
///     Background service for applying migrations.
///     It will automatically apply migrations on ASP application start.
/// </summary>
public class MigrationRunnerService(IServiceScopeFactory scopeFactory) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await using AsyncServiceScope scope = scopeFactory.CreateAsyncScope();
        await scope.UsePlatformMigrationsAsync(stoppingToken);
    }
}