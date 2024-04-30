using TimeTracker.Application.Abstractions.Persistence.Dto.ProblemRecord;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities;
using ProblemRecordModel = TimeTracker.Application.Models.ProblemRecord;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfProblemRecordRepository(ApplicationDbContext dbContext)
    : EfRepository<ProblemRecordEntity, ProblemRecordModel, ProblemRecordCreate, ProblemRecordUpdate>(dbContext), IProblemRecordRepository
{
    protected override ProblemRecordModel MapEntityToModel(ProblemRecordEntity entity)
    {
        return new ProblemRecordModel
        {
            EmployeeId = entity.EmployeeId,
            ProblemId = entity.ProblemId,
            StartTime = entity.StartTime,
            EndTime = entity.EndTime
        };
    }

    protected override ProblemRecordEntity MapCreateDtoToEntity(ProblemRecordCreate model)
    {
        return new ProblemRecordEntity
        {
            EmployeeId = model.EmployeeId,
            ProblemId = model.ProblemId,
            StartTime = model.StartTime,
            EndTime = model.EndTime
        };
    }

    protected override ProblemRecordEntity UpdateEntity(ProblemRecordEntity entity, ProblemRecordUpdate model)
    {
        entity.EmployeeId = model.EmployeeId ?? entity.EmployeeId;
        entity.ProblemId = model.ProblemId ?? entity.ProblemId;
        entity.StartTime = model.StartTime ?? entity.StartTime;
        entity.EndTime = model.EndTime ?? entity.EndTime;
        return entity;
    }
}