using TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.EmployeePositionHandlers;

public class UpdateEmployeePositionHandler(IUpdateRepository<EmployeePosition, EmployeePositionUpdate> repository)
    : UpdateOneHandler<EmployeePositionUpdate, EmployeePosition>(repository);