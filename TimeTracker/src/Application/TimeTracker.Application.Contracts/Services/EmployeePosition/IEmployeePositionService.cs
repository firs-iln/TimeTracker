using TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.EmployeePosition;

public interface IEmployeePositionService : IService<Models.EmployeePosition, EmployeePositionCreate, EmployeePositionUpdate>;