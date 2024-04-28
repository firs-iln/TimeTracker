using Microsoft.EntityFrameworkCore;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using UserEntity = TimeTracker.Infrastructure.Persistence.Entities.User;
using UserEntityRole = TimeTracker.Infrastructure.Persistence.Entities.Enums.UserRole;
using UserModel = TimeTracker.Application.Models.User;
using UserModelRole = TimeTracker.Application.Models.Enums.UserRole;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfUserRepository(ApplicationDbContext dbContext)
    : EfRepository<UserEntity, UserModel>(dbContext), IUserRepository
{
    public async Task<UserModel?> GetByUsernameAsync(string username)
    {
        UserEntity? entity = await DbSet.FirstOrDefaultAsync(user => user.Username == username);
        return entity != null ? MapEntityToModel(entity) : null;
    }

    protected override UserModel MapEntityToModel(UserEntity entity)
    {
        UserModelRole role = Enum.Parse<UserModelRole>(entity.Role.ToString());
        return new UserModel
        {
            Id = entity.Id,
            Username = entity.Username,
            HashedPassword = entity.HashedPassword,
            Role = role,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt
        };
    }

    // ReSharper disable once UnusedMember.Local
    protected override UserEntity MapModelToEntity(UserModel model)
    {
        UserEntityRole role = Enum.Parse<UserEntityRole>(model.Role.ToString());
        return new UserEntity
        {
            Id = model.Id,
            Username = model.Username,
            HashedPassword = model.HashedPassword,
            Role = role,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt
        };
    }
}