﻿using TimeTracker.Application.Abstractions.Persistence.Dto.Auth;
using TimeTracker.Application.Models;

namespace TimeTracker.Application.Abstractions.Persistence.Repositories;

public interface IAuthRepository : ICrudRepository<Auth, AuthCreate, AuthUpdate>
{
}