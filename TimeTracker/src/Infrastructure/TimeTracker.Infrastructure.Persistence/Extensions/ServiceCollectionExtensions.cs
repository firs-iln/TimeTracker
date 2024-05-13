using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TimeTracker.Application.Abstractions.Persistence;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;
using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Models;
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
        collection.AddScoped<IPositionRepository, EfPositionRepository>();
        collection.AddScoped<IEmployeePositionRepository, EfEmployeePositionRepository>();
        collection.AddScoped<IEmployeeRepository, EfEmployeeRepository>();
        collection.AddScoped<IDepartmentRepository, EfDepartmentRepository>();
        collection.AddScoped<IProblemRecordRepository, EfProblemRecordRepository>();
        collection.AddScoped<IProblemRepository, EfProblemRepository>();
        collection.AddScoped<IVacationRepository, EfVacationRepository>();
        collection.AddScoped<ITimeRecordRepository, EfTimeRecordRepository>();

        SetupActionRepositories(collection);

        return collection;
    }

    private static void SetupActionRepositories(IServiceCollection collection)
    {
        // User
        collection.AddScoped<IGetByIdRepository<User>, EfUserRepository>();
        collection.AddScoped<IGetByUsernameRepository<User>, EfUserRepository>();
        collection.AddScoped<IGetAllRepository<User>, EfUserRepository>();
        collection.AddScoped<ICreateRepository<User, UserCreate>, EfUserRepository>();
        collection.AddScoped<IUpdateRepository<User, UserUpdate>, EfUserRepository>();
        collection.AddScoped<IDeleteRepository<User>, EfUserRepository>();

        // Vacation
        collection.AddScoped<IGetByIdRepository<Vacation>, EfVacationRepository>();
        collection.AddScoped<IGetAllRepository<Vacation>, EfVacationRepository>();
        collection.AddScoped<ICreateRepository<Vacation, VacationCreate>, EfVacationRepository>();
        collection.AddScoped<IUpdateRepository<Vacation, VacationUpdate>, EfVacationRepository>();
        collection.AddScoped<IDeleteRepository<Vacation>, EfVacationRepository>();

        // TimeRecord
        collection.AddScoped<IGetByIdRepository<TimeRecord>, EfTimeRecordRepository>();
        collection.AddScoped<IGetAllRepository<TimeRecord>, EfTimeRecordRepository>();
        collection.AddScoped<ICreateRepository<TimeRecord, TimeRecordCreate>, EfTimeRecordRepository>();
        collection.AddScoped<IUpdateRepository<TimeRecord, TimeRecordUpdate>, EfTimeRecordRepository>();
        collection.AddScoped<IDeleteRepository<TimeRecord>, EfTimeRecordRepository>();

        // ProblemRecord
        collection.AddScoped<IGetByIdRepository<ProblemRecord>, EfProblemRecordRepository>();
        collection.AddScoped<IGetAllRepository<ProblemRecord>, EfProblemRecordRepository>();
        collection.AddScoped<ICreateRepository<ProblemRecord, ProblemRecordCreate>, EfProblemRecordRepository>();
        collection.AddScoped<IUpdateRepository<ProblemRecord, ProblemRecordUpdate>, EfProblemRecordRepository>();
        collection.AddScoped<IDeleteRepository<ProblemRecord>, EfProblemRecordRepository>();

        // Problem
        collection.AddScoped<IGetByIdRepository<Problem>, EfProblemRepository>();
        collection.AddScoped<IGetAllRepository<Problem>, EfProblemRepository>();
        collection.AddScoped<ICreateRepository<Problem, ProblemCreate>, EfProblemRepository>();
        collection.AddScoped<IUpdateRepository<Problem, ProblemUpdate>, EfProblemRepository>();
        collection.AddScoped<IDeleteRepository<Problem>, EfProblemRepository>();

        // Position
        collection.AddScoped<IGetByIdRepository<Position>, EfPositionRepository>();
        collection.AddScoped<IGetAllRepository<Position>, EfPositionRepository>();
        collection.AddScoped<ICreateRepository<Position, PositionCreate>, EfPositionRepository>();
        collection.AddScoped<IUpdateRepository<Position, PositionUpdate>, EfPositionRepository>();
        collection.AddScoped<IDeleteRepository<Position>, EfPositionRepository>();

        // EmployeePosition
        collection.AddScoped<IGetByIdRepository<EmployeePosition>, EfEmployeePositionRepository>();
        collection.AddScoped<IGetAllRepository<EmployeePosition>, EfEmployeePositionRepository>();
        collection.AddScoped<ICreateRepository<EmployeePosition, EmployeePositionCreate>, EfEmployeePositionRepository>();
        collection.AddScoped<IUpdateRepository<EmployeePosition, EmployeePositionUpdate>, EfEmployeePositionRepository>();
        collection.AddScoped<IDeleteRepository<EmployeePosition>, EfEmployeePositionRepository>();

        // Employee
        collection.AddScoped<IGetByIdRepository<Employee>, EfEmployeeRepository>();
        collection.AddScoped<IGetAllRepository<Employee>, EfEmployeeRepository>();
        collection.AddScoped<ICreateRepository<Employee, EmployeeCreate>, EfEmployeeRepository>();
        collection.AddScoped<IUpdateRepository<Employee, EmployeeUpdate>, EfEmployeeRepository>();
        collection.AddScoped<IDeleteRepository<Employee>, EfEmployeeRepository>();

        // Department
        collection.AddScoped<IGetByIdRepository<Department>, EfDepartmentRepository>();
        collection.AddScoped<IGetAllRepository<Department>, EfDepartmentRepository>();
        collection.AddScoped<ICreateRepository<Department, DepartmentCreate>, EfDepartmentRepository>();
        collection.AddScoped<IUpdateRepository<Department, DepartmentUpdate>, EfDepartmentRepository>();
        collection.AddScoped<IDeleteRepository<Department>, EfDepartmentRepository>();

        // Auth
        collection.AddScoped<ICreateRepository<Auth, AuthCreate>, EfAuthRepository>();
    }
}