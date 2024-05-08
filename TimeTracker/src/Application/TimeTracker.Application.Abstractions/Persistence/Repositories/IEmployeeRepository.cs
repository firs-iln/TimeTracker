using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IEmployeeRepository : ICrudRepository<Employee, EmployeeCreate, EmployeeUpdate>;