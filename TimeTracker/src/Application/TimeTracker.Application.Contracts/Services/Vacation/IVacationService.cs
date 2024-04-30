using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.Vacation;

public interface IVacationService : IService<Models.Vacation, VacationCreate, VacationUpdate>;