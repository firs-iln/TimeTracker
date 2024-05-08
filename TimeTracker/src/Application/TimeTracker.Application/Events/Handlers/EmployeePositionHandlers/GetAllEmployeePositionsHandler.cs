using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.EmployeePositionHandlers;

public class GetAllEmployeePositionsHandler(IGetAllRepository<EmployeePosition> repository)
    : GetAllHandler<EmployeePosition>(repository);