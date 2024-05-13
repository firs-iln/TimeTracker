namespace TimeTracker.Application.Exceptions;

public class TokenExpiredException(string message = "Your token has been expired") : BaseApplicationException(message);