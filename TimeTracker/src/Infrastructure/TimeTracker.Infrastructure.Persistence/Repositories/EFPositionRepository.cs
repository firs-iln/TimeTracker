using TimeTracker.Application.Abstractions.Persistence.Dto.Position;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities;
using PositionModel = TimeTracker.Application.Models.Position;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfPositionRepository(ApplicationDbContext dbContext)
    : EfRepository<PositionEntity, PositionModel, PositionCreate, PositionUpdate>(dbContext), IPositionRepository
{
    protected override PositionModel MapEntityToModel(PositionEntity entity)
    {
        return new PositionModel
        {
            Title = entity.Title,
            Description = entity.Description
        };
    }

    protected override PositionEntity MapCreateDtoToEntity(PositionCreate model)
    {
        return new PositionEntity
        {
            Title = model.Title,
            Description = model.Description
        };
    }

    protected override PositionEntity UpdateEntity(PositionEntity entity, PositionUpdate model)
    {
        entity.Title = model.Title ?? entity.Title;
        entity.Description = model.Description ?? entity.Description;
        return entity;
    }
}