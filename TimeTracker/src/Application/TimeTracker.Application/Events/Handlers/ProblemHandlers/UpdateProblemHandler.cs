using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.ProblemHandlers;

public class UpdateProblemHandler(IUpdateRepository<Problem, ProblemUpdate> repository)
    : UpdateOneHandler<ProblemUpdate, Problem>(repository);