using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.Position;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class PositionService(IPositionRepository repository) 
    : Service<IPositionRepository, Position, PositionCreate, PositionUpdate>(repository), IPositionService
{
    private readonly IPositionRepository _repository = repository;
}