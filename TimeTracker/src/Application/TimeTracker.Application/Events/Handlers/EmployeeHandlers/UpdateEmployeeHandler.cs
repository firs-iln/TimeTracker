using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.EmployeeHandlers;

public class UpdateEmployeeHandler(IUpdateRepository<Employee, EmployeeUpdate> repository)
    : UpdateOneHandler<EmployeeUpdate, Employee>(repository);