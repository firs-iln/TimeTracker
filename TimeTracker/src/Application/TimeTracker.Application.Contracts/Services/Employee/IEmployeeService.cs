using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.Employee;

public interface IEmployeeService : IService<Models.Employee, EmployeeCreate, EmployeeUpdate>;