using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.ProblemHandlers;

public class DeleteProblemHandler(IDeleteRepository<Problem> repository)
    : DeleteOneHandler<Problem>(repository);