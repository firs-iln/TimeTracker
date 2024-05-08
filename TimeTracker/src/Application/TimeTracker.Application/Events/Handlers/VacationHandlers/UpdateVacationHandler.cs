using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.VacationHandlers;

public class UpdateVacationHandler(IUpdateRepository<Vacation, VacationUpdate> repository)
    : UpdateOneHandler<VacationUpdate, Vacation>(repository);