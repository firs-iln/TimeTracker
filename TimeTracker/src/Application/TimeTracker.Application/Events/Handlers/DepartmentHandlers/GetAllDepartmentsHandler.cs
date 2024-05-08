using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.DepartmentHandlers;

public class GetAllDepartmentsHandler(IGetAllRepository<Department> repository) 
    : GetAllHandler<Department>(repository);