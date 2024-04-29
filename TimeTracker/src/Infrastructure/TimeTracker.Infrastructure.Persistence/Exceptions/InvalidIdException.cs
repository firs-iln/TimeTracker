namespace TimeTracker.Infrastructure.Persistence.Exceptions;

public class InvalidIdException<TEntity> : BasePersistenceException
{
    public InvalidIdException(Guid id)
        : base($"there is no {typeof(TEntity).FullName} with id {id}")
    {
    }
}