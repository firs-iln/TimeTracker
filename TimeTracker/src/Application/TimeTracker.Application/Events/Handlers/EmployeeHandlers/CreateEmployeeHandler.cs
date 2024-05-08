using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.EmployeeHandlers;

public class CreateEmployeeHandler(ICreateRepository<Employee, EmployeeCreate> repository) 
    : CreateOneHandler<EmployeeCreate, Employee>(repository);