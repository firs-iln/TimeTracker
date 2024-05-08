using TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IEmployeePositionRepository : ICrudRepository<EmployeePosition, EmployeePositionCreate, EmployeePositionUpdate>;