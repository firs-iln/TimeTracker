using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface ITimeRecordRepository : ICrudRepository<TimeRecord, TimeRecordCreate, TimeRecordUpdate>
{
}