using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IVacationRepository : ICrudRepository<Vacation, VacationCreate, VacationUpdate>;