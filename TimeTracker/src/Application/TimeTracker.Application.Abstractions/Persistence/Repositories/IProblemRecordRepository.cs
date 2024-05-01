using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IProblemRecordRepository : ICrudRepository<ProblemRecord, ProblemRecordCreate, ProblemRecordUpdate>;