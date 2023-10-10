using Domain.Exceptions;

namespace Domain.ValueObjects;

public class NameVo
{
    public NameVo(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Validate();
    }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
    public bool IsValid()
    {
        return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
    }

    private void Validate()
    {
        if (!IsValid())
        {
            throw new InvalidNameException("Invalid Name");
        }
    }
}

