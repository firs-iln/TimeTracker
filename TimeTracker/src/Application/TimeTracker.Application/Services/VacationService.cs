using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Vacation;
using TimeTracker.Application.Models;
using TimeTracker.Application.Services.Abstractions;

namespace TimeTracker.Application.Services;

public class VacationService(IVacationRepository repository) 
    : Service<IVacationRepository, Vacation, VacationCreate, VacationUpdate>(repository), IVacationService;