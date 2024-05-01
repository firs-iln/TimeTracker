using TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.EmployeePosition;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class EmployeePositionService(IEmployeePositionRepository repository) 
    : Service<IEmployeePositionRepository, EmployeePosition, EmployeePositionCreate, EmployeePositionUpdate>(repository), IEmployeePositionService;