using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.TimeRecord;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class TimeRecordService(ITimeRecordRepository repository) 
    : Service<ITimeRecordRepository, TimeRecord, TimeRecordCreate, TimeRecordUpdate>(repository), ITimeRecordService
{
    private readonly ITimeRecordRepository _repository = repository;
}