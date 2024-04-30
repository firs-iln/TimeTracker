namespace TimeTracker.Application.Exceptions;

public class WrongCredentialsException : BaseApplicationException
{
    public WrongCredentialsException()
        : base("credentials are wrong, please try again")
    {
    }
}