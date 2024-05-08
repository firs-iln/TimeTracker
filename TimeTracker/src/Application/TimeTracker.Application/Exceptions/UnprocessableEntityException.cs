namespace TimeTracker.Application.Exceptions;

public class UnprocessableEntityException(string message = "") : BaseApplicationException(message);