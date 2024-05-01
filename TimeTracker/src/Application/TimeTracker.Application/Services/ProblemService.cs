using TimeTracker.Application.Abstractions.Persistence.Dto.Problem;
using TimeTracker.Application.Abstractions.Persistence.Repositories;
using TimeTracker.Application.Contracts.Services.Abstractions;
using TimeTracker.Application.Contracts.Services.Problem;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Services;

public class ProblemService(IProblemRepository repository) 
    : Service<IProblemRepository, Problem, ProblemCreate, ProblemUpdate>(repository), IProblemService;