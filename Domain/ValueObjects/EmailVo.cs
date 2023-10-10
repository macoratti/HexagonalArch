using Domain.Exceptions;

namespace Domain.ValueObjects;

public class EmailVo
{
    public EmailVo(string address)
    {
        Address = address;
        Validate();
    }

    public string Address { get; private set; }

    public bool IsValid()
    {
        return !string.IsNullOrEmpty(Address) && Address.Contains("@");
    }

    private void Validate()
    {
        if (!IsValid())
        {
            throw new InvalidEmailException("Invalid Email");
        }
    }
}
