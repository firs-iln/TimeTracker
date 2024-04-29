using Microsoft.Extensions.DependencyInjection;
using TimeTracker.Application.Contracts.Services.User;
using TimeTracker.Application.Services;

namespace TimeTracker.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        // TODO: add services
        collection.AddScoped<IUserService, UserService>();
        return collection;
    }
}