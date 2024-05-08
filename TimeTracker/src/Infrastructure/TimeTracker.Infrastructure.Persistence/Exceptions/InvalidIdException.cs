namespace TimeTracker.Infrastructure.Persistence.Exceptions;

public class InvalidIdException<TEntity>(Guid id)
    : BasePersistenceException($"there is no {typeof(TEntity).FullName} with id {id}");