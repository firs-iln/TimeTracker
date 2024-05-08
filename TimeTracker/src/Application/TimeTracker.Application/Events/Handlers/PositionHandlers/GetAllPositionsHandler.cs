using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.PositionHandlers;

public class GetAllPositionsHandler(IGetAllRepository<Position> repository) 
    : GetAllHandler<Position>(repository);