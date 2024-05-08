using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.DepartmentHandlers;

public class GetDepartmentHandler(IGetByIdRepository<Department> repository)
    : GetOneByIdHandler<Department>(repository);