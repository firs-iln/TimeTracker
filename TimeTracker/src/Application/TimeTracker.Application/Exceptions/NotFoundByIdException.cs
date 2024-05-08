namespace TimeTracker.Application.Exceptions;

public class NotFoundByIdException(Guid id, Type entityType) 
    : BaseApplicationException($"there is no {entityType.FullName} with id {id}");