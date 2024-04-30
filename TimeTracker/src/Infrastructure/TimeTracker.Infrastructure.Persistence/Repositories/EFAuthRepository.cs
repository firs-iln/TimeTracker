using Microsoft.EntityFrameworkCore;
using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities;
using AuthModel = TimeTracker.Application.Models.Auth;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfAuthRepository(ApplicationDbContext dbContext)
    : EfRepository<AuthEntity, AuthModel, AuthCreate, AuthUpdate>(dbContext), IAuthRepository
{
    public async Task RevokeTokenAsync(string token)
    {
        var entity = await DbSet.Where(x => x.Refresh == token).FirstOrDefaultAsync();
        if (entity is not null)
        {
            DbSet.Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    }

    public async Task<AuthModel?> GetByRefreshTokenAsync(string token)
    {
        var entity = await DbSet.Where(x => x.Refresh == token).FirstOrDefaultAsync();
        return entity != null ? MapEntityToModel(entity) : null;
    }

    public async Task<AuthModel?> GetByUserIdAsync(Guid userId)
    {
        var entity = await DbSet.Where(x => x.UserId == userId).FirstOrDefaultAsync();
        return entity != null ? MapEntityToModel(entity) : null;
    }

    protected override AuthModel MapEntityToModel(AuthEntity entity)
    {
        return new AuthModel
        {
            UserId = entity.UserId,
            Refresh = entity.Refresh,
            Access = entity.Access
        };
    }

    protected override AuthEntity MapCreateDtoToEntity(AuthCreate model)
    {
        return new AuthEntity
        {
            UserId = model.UserId,
            Refresh = model.Refresh,
            Access = model.Access
        };
    }

    protected override AuthEntity UpdateEntity(AuthEntity entity, AuthUpdate model)
    {
        entity.UserId = model.UserId ?? entity.UserId;
        entity.Refresh = model.Refresh ?? entity.Refresh;
        entity.Access = model.Access ?? entity.Access;
        return entity;
    }
}