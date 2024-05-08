using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.ProblemRecordHandlers;

public class CreateProblemRecordHandler(ICreateRepository<ProblemRecord, ProblemRecordCreate> repository)
    : CreateOneHandler<ProblemRecordCreate, ProblemRecord>(repository);