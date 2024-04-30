using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Infrastructure.Persistence.Context;
using ProblemEntity = TimeTracker.Infrastructure.Persistence.Entities.Problem;
using ProblemEntityStatus = TimeTracker.Infrastructure.Persistence.Entities.Enums.ProblemStatus;
using ProblemModel = TimeTracker.Application.Models.Problem;
using ProblemModelStatus = TimeTracker.Application.Models.Enums.ProblemStatus;

namespace TimeTracker.Infrastructure.Persistence.Repositories;

public class EfProblemRepository(ApplicationDbContext dbContext)
    : EfRepository<ProblemEntity, ProblemModel, ProblemCreate, ProblemUpdate>(dbContext), IProblemRepository
{
    protected override ProblemModel MapEntityToModel(ProblemEntity entity)
    {
        ProblemModelStatus problemStatus = Enum.Parse<ProblemModelStatus>(entity.Status.ToString());
        return new ProblemModel
        {
            Description = entity.Description,
            Status = problemStatus,
            Deadline = entity.Deadline,
            DepartmentId = entity.DepartmentId
        };
    }

    protected override ProblemEntity MapCreateDtoToEntity(ProblemCreate model)
    {
        ProblemEntityStatus problemStatus = Enum.Parse<ProblemEntityStatus>(model.Status.ToString());
        return new ProblemEntity
        {
            Description = model.Description,
            Status = problemStatus,
            Deadline = model.Deadline,
            DepartmentId = model.DepartmentId
        };
    }

    protected override ProblemEntity UpdateEntity(ProblemEntity entity, ProblemUpdate model)
    {
        ProblemEntityStatus problemStatus = Enum.Parse<ProblemEntityStatus>(model.Status.ToString() ?? entity.Status.ToString());
        entity.Description = model.Description ?? entity.Description;
        entity.Status = problemStatus;
        entity.Deadline = model.Deadline ?? entity.Deadline;
        entity.DepartmentId = model.DepartmentId ?? entity.DepartmentId;
        return entity;
    }
}