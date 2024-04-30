using TimeTracker.Application.Abstractions.Persistence.Dto.EmployeePosition;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities;
using EmployeePositionModel = TimeTracker.Application.Models.EmployeePosition;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfEmployeePositionRepository(ApplicationDbContext dbContext)
    : EfRepository<EmployeePositionEntity, EmployeePositionModel, EmployeePositionCreate, EmployeePositionUpdate>(
        dbContext), IEmployeePositionRepository
{
    protected override EmployeePositionModel MapEntityToModel(EmployeePositionEntity entity)
    {
        return new EmployeePositionModel
        {
            EmployeeId = entity.EmployeeId,
            PositionId = entity.PositionId,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            WorkSchedule = entity.WorkSchedule,
            Salary = entity.Salary,
            DepartmentId = entity.DepartmentId
        };
    }

    protected override EmployeePositionEntity MapCreateDtoToEntity(EmployeePositionCreate model)
    {
        return new EmployeePositionEntity
        {
            EmployeeId = model.EmployeeId,
            PositionId = model.PositionId,
            StartDate = model.StartDate,
            EndDate = model.EndDate,
            WorkSchedule = model.WorkSchedule,
            Salary = model.Salary,
            DepartmentId = model.DepartmentId
        };
    }

    protected override EmployeePositionEntity UpdateEntity(EmployeePositionEntity entity, EmployeePositionUpdate model)
    {
        entity.EmployeeId = model.EmployeeId ?? entity.EmployeeId;
        entity.PositionId = model.PositionId ?? entity.PositionId;
        entity.StartDate = model.StartDate ?? entity.StartDate;
        entity.EndDate = model.EndDate ?? entity.EndDate;
        entity.WorkSchedule = model.WorkSchedule ?? entity.WorkSchedule;
        entity.Salary = model.Salary ?? entity.Salary;
        entity.DepartmentId = model.DepartmentId ?? entity.DepartmentId;
        return entity;
    }
}