using TimeTracker.Application.Abstractions.Persistence.Repositories.ActionRepositories;
using TimeTracker.Application.Events.Handlers.Abstractions;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Events.Handlers.UserHandlers;

public class DeleteUserHandler(IDeleteRepository<User> repository) 
    : DeleteOneHandler<User>(repository);