using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.VacationHandlers;

public class GetAllVacationsHandler(IGetAllRepository<Vacation> repository)
    : GetAllHandler<Vacation>(repository);