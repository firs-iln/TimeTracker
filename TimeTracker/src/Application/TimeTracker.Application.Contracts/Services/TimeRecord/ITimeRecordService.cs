using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.TimeRecord;

public interface ITimeRecordService : IService<Models.TimeRecord, TimeRecordCreate, TimeRecordUpdate>;