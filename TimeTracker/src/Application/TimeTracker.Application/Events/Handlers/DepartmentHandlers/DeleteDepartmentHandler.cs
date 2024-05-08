using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.DepartmentHandlers;

public class DeleteDepartmentHandler(IDeleteRepository<Department> repository) 
    : DeleteOneHandler<Department>(repository);