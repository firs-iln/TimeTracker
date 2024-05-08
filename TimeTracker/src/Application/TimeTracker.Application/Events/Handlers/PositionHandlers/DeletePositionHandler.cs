using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.PositionHandlers;

public class DeletePositionHandler(IDeleteRepository<Position> repository) 
    : DeleteOneHandler<Position>(repository);