namespace Domain.Exceptions;

public class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) : base(message) { }
}
