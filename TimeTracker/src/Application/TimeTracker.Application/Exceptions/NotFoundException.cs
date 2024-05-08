namespace TimeTracker.Application.Exceptions;

public class NotFoundException(string entityName) : BaseApplicationException($"{entityName} not found");