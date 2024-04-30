using TimeTracker.Application.Abstractions.Persistence.Dto.Department;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities;
using DepartmentModel = TimeTracker.Application.Models.Department;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfDepartmentRepository(ApplicationDbContext dbContext)
    : EfRepository<DepartmentEntity, DepartmentModel, DepartmentCreate, DepartmentUpdate>(dbContext), IDepartmentRepository
{
    protected override DepartmentModel MapEntityToModel(DepartmentEntity entity)
    {
        return new DepartmentModel
        {
            Id = entity.Id,
            Name = entity.Name,
            ManagerId = entity.ManagerId,
        };
    }

    protected override DepartmentEntity MapCreateDtoToEntity(DepartmentCreate model)
    {
        return new DepartmentEntity
        {
            Name = model.Name,
            ManagerId = model.ManagerId
        };
    }

    protected override DepartmentEntity UpdateEntity(DepartmentEntity entity, DepartmentUpdate model)
    {
        entity.Name = model.Name ?? entity.Name;
        return entity;
    }
}