using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.ProblemRecord;

public interface IProblemRecordService : IService<Models.ProblemRecord, ProblemRecordCreate, ProblemRecordUpdate>;