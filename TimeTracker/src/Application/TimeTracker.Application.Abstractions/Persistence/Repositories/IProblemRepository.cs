using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IProblemRepository : ICrudRepository<Problem, ProblemCreate, ProblemUpdate>;