using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.Employee;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class EmployeeService(IEmployeeRepository repository) 
    : Service<IEmployeeRepository, Employee, EmployeeCreate, EmployeeUpdate>(repository), IEmployeeService
{
    private readonly IEmployeeRepository _repository = repository;
}