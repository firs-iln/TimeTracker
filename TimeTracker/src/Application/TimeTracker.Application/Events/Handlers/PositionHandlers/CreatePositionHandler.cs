using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.PositionHandlers;

public class CreatePositionHandler(ICreateRepository<Position, PositionCreate> repository) 
    : CreateOneHandler<PositionCreate, Position>(repository);