using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.Department;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class DepartmentService(IDepartmentRepository repository) 
    : Service<IDepartmentRepository, Department, DepartmentCreate, DepartmentUpdate>(repository), IDepartmentService
{
    private readonly IDepartmentRepository _repository = repository;
}