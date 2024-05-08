using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.TimeRecordHandlers;

public class DeleteTimeRecordHandler(IDeleteRepository<TimeRecord> repository)
    : DeleteOneHandler<TimeRecord>(repository);