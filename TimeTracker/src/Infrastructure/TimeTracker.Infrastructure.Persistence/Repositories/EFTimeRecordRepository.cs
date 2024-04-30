using TimeTracker.Application.Abstractions.Persistence.Dto.TimeRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Models;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities;
using TimeRecordModel = TimeTracker.Application.Models.TimeRecord;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfTimeRecordRepository(ApplicationDbContext dbContext)
    : EfRepository<TimeRecordEntity, TimeRecordModel, TimeRecordCreate, TimeRecordUpdate>(dbContext), ITimeRecordRepository
{
    protected override TimeRecordModel MapEntityToModel(TimeRecordEntity entity)
    {
        return new TimeRecordModel
        {
            EmployeeId = entity.EmployeeId,
            StartTime = entity.StartTime,
            EndTime = entity.EndTime
        };
    }

    protected override TimeRecordEntity MapCreateDtoToEntity(TimeRecordCreate model)
    {
        return new TimeRecordEntity
        {
            EmployeeId = model.EmployeeId,
            StartTime = model.StartTime,
            EndTime = model.EndTime
        };
    }

    protected override TimeRecordEntity UpdateEntity(TimeRecordEntity entity, TimeRecordUpdate model)
    {
        entity.EmployeeId = model.EmployeeId ?? entity.EmployeeId;
        entity.StartTime = model.StartTime ?? entity.StartTime;
        entity.EndTime = model.EndTime ?? entity.EndTime;
        return entity;
    }
}