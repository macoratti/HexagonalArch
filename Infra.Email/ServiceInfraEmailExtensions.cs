using Domain.Adapters;
using Infra.Email.Operations;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Email;

public static class ServiceInfraEmailExtensions
{
    public static IServiceCollection AddEmailService(this IServiceCollection services)
    {
        services.AddTransient<IEmailService, FakeEmailAdapter>();
        return services;
    }
}
