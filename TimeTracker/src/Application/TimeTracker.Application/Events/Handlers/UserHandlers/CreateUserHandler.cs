using TimeTracker.Application.Abstractions.Persistence.Dto.User;
using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.UserHandlers;

public class CreateUserHandler(ICreateRepository<User, UserCreate> repository) 
    : CreateOneHandler<UserCreate, User>(repository);