namespace TimeTracker.Application.Exceptions;

public class BaseApplicationException(string message = "something went wrong") : Exception(message);