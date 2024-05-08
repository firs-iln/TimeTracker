using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.ProblemHandlers;

public class GetAllProblemsHandler(IGetAllRepository<Problem> repository)
    : GetAllHandler<Problem>(repository);