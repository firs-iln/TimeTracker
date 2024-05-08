using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.EmployeeHandlers;

public class DeleteEmployeeHandler(IDeleteRepository<Employee> repository) 
    : DeleteOneHandler<Employee>(repository);