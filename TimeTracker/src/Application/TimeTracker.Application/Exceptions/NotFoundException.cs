namespace TimeTracker.Application.Exceptions;

public class NotFoundException : BaseApplicationException
{
    public NotFoundException(string entityName)
        : base($"{entityName} not found")
    {
    }
}