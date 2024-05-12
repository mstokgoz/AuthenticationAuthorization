using Microsoft.Extensions.DependencyInjection;

namespace AuthenticationAuthorization.Application;

public static class ServiceRegistrations
{
    public static void AddApplicationServiceRegistrations(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblyContaining(typeof(ServiceRegistrations));
        });
    }
}