using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.Department;

public interface IDepartmentService : IService<Models.Department, DepartmentCreate, DepartmentUpdate>;