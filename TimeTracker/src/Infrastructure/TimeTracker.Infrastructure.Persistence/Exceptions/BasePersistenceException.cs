namespace TimeTracker.Infrastructure.Persistence.Exceptions;

public class BasePersistenceException : Exception
{
    public BasePersistenceException(string message = "something went wrong")
        : base(message)
    {
    }
}