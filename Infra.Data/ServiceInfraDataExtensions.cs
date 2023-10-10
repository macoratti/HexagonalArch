using Domain.Adapters;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data;

public static class ServiceInfraDataExtensions
{
    public static IServiceCollection AddDataBaseInMemoryService(this IServiceCollection services)
    {
        services.AddDbContext<InMemoryContext>(options => options.UseInMemoryDatabase("test"));
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
