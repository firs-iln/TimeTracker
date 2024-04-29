using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IPositionRepository : ICrudRepository<Position, PositionCreate, PositionUpdate>
{
}