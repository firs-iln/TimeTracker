using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker.Application.Abstractions.Persistence;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Plugins;
using TimeTracker.Infrastructure.Persistence.Repositories;

namespace TimeTracker.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(
        this IServiceCollection collection,
        IConfiguration configuration)
    {
        collection.AddPlatformPostgres(builder => builder.BindConfiguration("Infrastructure:Persistence:Postgres"));
        collection.AddSingleton<IDataSourcePlugin, MappingPlugin>();

        collection.AddPlatformMigrations(typeof(IAssemblyMarker).Assembly);

        // collection.AddHostedService<MigrationRunnerService>();
        collection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetSection("Infrastructure:Persistence:Postgres:ConnectionString").Value));

        // TODO: add repositories
        collection.AddScoped<IPersistenceContext, PersistenceContext>();
        collection.AddScoped<IUserRepository, EfUserRepository>();
        collection.AddScoped<IAuthRepository, EfAuthRepository>();

        return collection;
    }
}