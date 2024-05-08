using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.PositionHandlers;

public class GetPositionHandler(IGetByIdRepository<Position> repository)
    : GetOneByIdHandler<Position>(repository);