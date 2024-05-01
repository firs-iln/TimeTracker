using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.ProblemRecord;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class ProblemRecordService(IProblemRecordRepository repository) 
    : Service<IProblemRecordRepository, ProblemRecord, ProblemRecordCreate, ProblemRecordUpdate>(repository), IProblemRecordService;