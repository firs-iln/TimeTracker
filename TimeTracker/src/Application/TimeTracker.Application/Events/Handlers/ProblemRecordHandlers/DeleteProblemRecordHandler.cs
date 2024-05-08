using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.ProblemRecordHandlers;

public class DeleteProblemRecordHandler(IDeleteRepository<ProblemRecord> repository)
    : DeleteOneHandler<ProblemRecord>(repository);