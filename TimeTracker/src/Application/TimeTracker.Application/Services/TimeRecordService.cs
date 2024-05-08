using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.TimeRecord;
using TimeTracker.Application.Models;
using TimeTracker.Application.Services.Abstractions;

namespace TimeTracker.Application.Services;

public class TimeRecordService(ITimeRecordRepository repository) 
    : Service<ITimeRecordRepository, TimeRecord, TimeRecordCreate, TimeRecordUpdate>(repository), ITimeRecordService;