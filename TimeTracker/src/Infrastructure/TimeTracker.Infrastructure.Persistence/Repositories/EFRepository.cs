using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Models.Abstractions;
using TimeTracker.Infrastructure.Persistence.Context;
using TimeTracker.Infrastructure.Persistence.Entities.Abstractions;
using TimeTracker.Infrastructure.Persistence.Exceptions;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public abstract class EfRepository<TEntity, TModel, TCreateDto, TUpdateDto>(ApplicationDbContext dbContext) : ICrudRepository<TModel, TCreateDto, TUpdateDto>
    where TEntity : BaseEntity
    where TModel : BaseModel
    where TCreateDto : class
    where TUpdateDto : class
{
    protected ApplicationDbContext DbContext { get; } = dbContext;

    protected DbSet<TEntity> DbSet { get; } = dbContext.Set<TEntity>();

    public async Task<TModel?> GetAsync(Guid id)
    {
        TEntity? entity = await DbSet.FindAsync(id);
        return entity != null ? MapEntityToModel(entity) : null;
    }

    public async Task<TModel?> CreateAsync(TCreateDto model)
    {
        TEntity entityToCreate = MapCreateDtoToEntity(model);
        await DbSet.AddAsync(entityToCreate);
        await DbContext.SaveChangesAsync();
        await ReloadEntity(entityToCreate);
        return MapEntityToModel(entityToCreate);
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

    public async Task<TModel> UpdateAsync(Guid id, TUpdateDto model)
    {
        TEntity? currentEntity = await DbSet.FindAsync(id);
        if (currentEntity == null)
        {
            throw new InvalidIdException<TEntity>(id);
        }

        TEntity entityToUpdate = UpdateEntity(currentEntity, model);
        DbSet.Update(entityToUpdate);
        await DbContext.SaveChangesAsync();
        await ReloadEntity(entityToUpdate);
        return MapEntityToModel(entityToUpdate);
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

    protected async Task ReloadEntity(TEntity entity)
    {
         await DbContext.Entry(entity).ReloadAsync();
    }

    protected abstract TModel MapEntityToModel(TEntity entity);

    protected abstract TEntity MapCreateDtoToEntity(TCreateDto model);

    protected abstract TEntity UpdateEntity(TEntity entity, TUpdateDto model);
}