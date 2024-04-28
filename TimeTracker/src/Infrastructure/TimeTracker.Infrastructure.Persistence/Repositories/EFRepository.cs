using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Models.Abstractions;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public abstract class EfRepository<TEntity, TModel>(ApplicationDbContext dbContext) : ICrudRepository<TModel>
    where TEntity : BaseEntity
    where TModel : BaseModel
{
    protected ApplicationDbContext DbContext { get; } = dbContext;

    protected DbSet<TEntity> DbSet { get; } = dbContext.Set<TEntity>();

    public async Task<TModel?> GetAsync(Guid id)
    {
        TEntity? entity = await DbSet.FindAsync(id);
        return entity != null ? MapEntityToModel(entity) : null;
    }

    public async Task<TModel?> CreateAsync(TModel entity)
    {
        TEntity entityToCreate = MapModelToEntity(entity);
        await DbSet.AddAsync(entityToCreate);
        await DbContext.SaveChangesAsync();
        entity.Id = entityToCreate.Id;
        return entity;
    }

    public async Task<IEnumerable<TModel?>> GetAllAsync()
    {
        IEnumerable<TEntity> entities = await DbSet.ToListAsync();
        return entities.Select(MapEntityToModel);
    }

    public Task<IEnumerable<TModel?>> GetByFilterAsync(Expression<Func<TModel?, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public async Task<TModel> UpdateAsync(Guid id, TModel entity)
    {
        TEntity entityToUpdate = MapModelToEntity(entity);
        DbSet.Update(entityToUpdate);
        await DbContext.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(Guid id)
    {
        TEntity? entity = await DbSet.FindAsync(id);
        if (entity != null)
        {
            DbSet.Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    }

    protected abstract TModel MapEntityToModel(TEntity entity);

    protected abstract TEntity MapModelToEntity(TModel model);
}