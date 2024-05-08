using Microsoft.Extensions.DependencyInjection;
using TimeTracker.Application.Contracts.Services.Auth;
using TimeTracker.Application.Contracts.Services.Department;
using TimeTracker.Application.Contracts.Services.Employee;
using TimeTracker.Application.Contracts.Services.EmployeePosition;
using TimeTracker.Application.Contracts.Services.Position;
using TimeTracker.Application.Contracts.Services.Problem;
using TimeTracker.Application.Contracts.Services.ProblemRecord;
using TimeTracker.Application.Contracts.Services.TimeRecord;
using TimeTracker.Application.Contracts.Services.User;
using TimeTracker.Application.Contracts.Services.Vacation;
using TimeTracker.Application.Services;

namespace TimeTracker.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        // TODO: add services
        collection.AddScoped<IUserService, UserService>();
        collection.AddScoped<IAuthService, AuthService>();
        collection.AddScoped<IDepartmentService, DepartmentService>();
        collection.AddScoped<IPositionService, PositionService>();
        collection.AddScoped<IEmployeeService, EmployeeService>();
        collection.AddScoped<IEmployeePositionService, EmployeePositionService>();
        collection.AddScoped<ITimeRecordService, TimeRecordService>();
        collection.AddScoped<IProblemService, ProblemService>();
        collection.AddScoped<IProblemRecordService, ProblemRecordService>();
        collection.AddScoped<IVacationService, VacationService>();

        return collection;
    }
}