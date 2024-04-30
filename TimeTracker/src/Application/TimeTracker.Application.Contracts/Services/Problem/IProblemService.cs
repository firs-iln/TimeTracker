using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Contracts.Services.Abstractions;

namespace TimeTracker.Application.Contracts.Services.Problem;

public interface IProblemService : IService<Models.Problem, ProblemCreate, ProblemUpdate>;