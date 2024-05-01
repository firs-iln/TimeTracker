using TimeTracker.Application.Abstractions.Persistence.Dto.Vacation;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities;
using VacationEntityType = TimeTracker.Infrastructure.Persistence.Entities.Enums.VacationType;
using VacationModel = TimeTracker.Application.Models.Vacation;
using VacationModelType = TimeTracker.Application.Models.Enums.VacationType;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfVacationRepository(ApplicationDbContext dbContext)
    : EfRepository<VacationEntity, VacationModel, VacationCreate, VacationUpdate>(dbContext), IVacationRepository
{
    protected override VacationModel MapEntityToModel(VacationEntity entity)
    {
        VacationModelType vacationType = Enum.Parse<VacationModelType>(entity.Type.ToString());
        return new VacationModel
        {
            EmployeeId = entity.EmployeeId,
            Type = vacationType,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
        };
    }

    protected override VacationEntity MapCreateDtoToEntity(VacationCreate model)
    {
        VacationEntityType vacationType = Enum.Parse<VacationEntityType>(model.Type.ToString());
        return new VacationEntity
        {
            EmployeeId = model.EmployeeId,
            Type = vacationType,
            StartDate = model.StartDate,
            EndDate = model.EndDate
        };
    }

    protected override VacationEntity UpdateEntity(VacationEntity entity, VacationUpdate model)
    {
        entity.EmployeeId = model.EmployeeId ?? entity.EmployeeId;
        entity.Type = Enum.Parse<VacationEntityType>(model.Type.ToString() ?? entity.Type.ToString());
        entity.StartDate = model.StartDate ?? entity.StartDate;
        entity.EndDate = model.EndDate ?? entity.EndDate;
        return entity;
    }
}