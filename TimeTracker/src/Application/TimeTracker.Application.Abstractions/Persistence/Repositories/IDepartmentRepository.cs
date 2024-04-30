using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IDepartmentRepository : ICrudRepository<Department, DepartmentCreate, DepartmentUpdate>;