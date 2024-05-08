using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.TimeRecordHandlers;

public class UpdateTimeRecordHandler(IUpdateRepository<TimeRecord, TimeRecordUpdate> repository)
    : UpdateOneHandler<TimeRecordUpdate, TimeRecord>(repository);