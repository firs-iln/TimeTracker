using TimeTracker.Application.Abstractions.Persistence.Dto.Employee;
using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using EmployeeEntity = TimeTracker.Infrastructure.Persistence.Entities.Employee;
using EmployeeModel = TimeTracker.Application.Models.Employee;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfEmployeeRepository(ApplicationDbContext dbContext)
    : EfRepository<EmployeeEntity, EmployeeModel, EmployeeCreate, EmployeeUpdate>(dbContext), IEmployeeRepository
{
    protected override EmployeeModel MapEntityToModel(EmployeeEntity entity)
    {
        return new EmployeeModel
        {
            UserId = entity.User.Id,
            FullName = entity.FullName,
            PassportData = entity.PassportData,
            PhoneNumber = entity.PhoneNumber,
            Email = entity.Email,
            DateOfBirth = entity.DateOfBirth,
            Id = entity.Id,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt
        };
    }

    protected override EmployeeEntity MapCreateDtoToEntity(EmployeeCreate model)
    {
        return new EmployeeEntity
        {
            UserId = model.UserId,
            FullName = model.FullName,
            PassportData = model.PassportData,
            PhoneNumber = model.PhoneNumber,
            Email = model.Email,
            DateOfBirth = model.DateOfBirth
        };
    }

    protected override EmployeeEntity UpdateEntity(EmployeeEntity entity, EmployeeUpdate model)
    {
        entity.UserId = model.UserId ?? entity.UserId;
        entity.FullName = model.FullName ?? entity.FullName;
        entity.PassportData = model.PassportData ?? entity.PassportData;
        entity.PhoneNumber = model.PhoneNumber ?? entity.PhoneNumber;
        entity.Email = model.Email ?? entity.Email;
        entity.DateOfBirth = model.DateOfBirth ?? entity.DateOfBirth;
        return entity;
    }
}
