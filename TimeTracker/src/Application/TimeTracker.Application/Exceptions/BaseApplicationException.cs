namespace TimeTracker.Application.Exceptions;

public class BaseApplicationException : Exception
{
    public BaseApplicationException(string message = "something went wrong")
        : base(message)
    {
    }
}