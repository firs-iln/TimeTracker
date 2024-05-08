using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Position;
using TimeTracker.Application.Models;
using TimeTracker.Application.Services.Abstractions;

namespace TimeTracker.Application.Services;

public class PositionService(IPositionRepository repository) 
    : Service<IPositionRepository, Position, PositionCreate, PositionUpdate>(repository), IPositionService;