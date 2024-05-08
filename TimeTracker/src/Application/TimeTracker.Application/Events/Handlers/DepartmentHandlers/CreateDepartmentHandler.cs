using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.DepartmentHandlers;

public class CreateDepartmentHandler(ICreateRepository<Department, DepartmentCreate> repository) 
    : CreateOneHandler<DepartmentCreate, Department>(repository);