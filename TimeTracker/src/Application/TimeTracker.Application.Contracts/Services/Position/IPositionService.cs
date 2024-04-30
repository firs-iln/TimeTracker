using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.Position;

public interface IPositionService : IService<Models.Position, PositionCreate, PositionUpdate>;