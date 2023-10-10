using Domain.Adapters;
using Microsoft.Extensions.Logging;

namespace Infra.Email.Operations;

public class FakeEmailAdapter : IEmailService
{
    private readonly ILogger<FakeEmailAdapter> _logger;

    public FakeEmailAdapter(ILogger<FakeEmailAdapter> logger)
    {
        _logger = logger;
    }

    public void SendEmail(string from, string to, string subject, string body)
    {
        var logMessage = $"Enviando e-mail:\nDe: {from}\nPara: {to}\nAssunto: {subject}\nCorpo:\n{body}";
        _logger.LogInformation(logMessage);
    }
}
