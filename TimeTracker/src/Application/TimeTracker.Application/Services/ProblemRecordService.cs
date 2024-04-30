using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.ProblemRecord;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class ProblemRecordService(IProblemRecordRepository repository) 
    : Service<IProblemRecordRepository, ProblemRecord, ProblemCreate, ProblemUpdate>(repository), IProblemRecordService
{
    private readonly IProblemRecordRepository _repository = repository;
    public Task<ProblemRecord?> CreateAsync(ProblemRecordCreate model)
    {
        throw new NotImplementedException();
    }

    public Task<ProblemRecord?> UpdateAsync(Guid id, ProblemRecordUpdate model)
    {
        throw new NotImplementedException();
    }
}