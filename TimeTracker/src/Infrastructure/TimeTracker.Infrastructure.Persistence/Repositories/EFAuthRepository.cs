using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using AuthEntity = TimeTracker.Infrastructure.Persistence.Entities.Auth;
using AuthModel = TimeTracker.Application.Models.Auth;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EFAuthRepository(ApplicationDbContext dbContext)
    : EfRepository<AuthEntity, AuthModel, AuthCreate, AuthUpdate>(dbContext), IAuthRepository
{
    protected override AuthModel MapEntityToModel(AuthEntity entity)
    {
        return new AuthModel
        {
            UserId = entity.UserId,
            Refresh = entity.Refresh
        };
    }

    protected override AuthEntity MapCreateDtoToEntity(AuthCreate model)
    {
        return new AuthEntity
        {
            UserId = model.UserId,
            Refresh = model.Refresh
        };
    }

    protected override AuthEntity UpdateEntity(AuthEntity entity, AuthUpdate model)
    {
        entity.UserId = model.UserId ?? entity.UserId;
        entity.Refresh = model.Refresh ?? entity.Refresh;
        return entity;
    }
}