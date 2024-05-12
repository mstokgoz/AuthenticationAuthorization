using AuthenticationAuthorization.Application.Abstractions;
using AuthenticationAuthorization.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticationAuthorization.Infrastructure;

public static class ServiceRegistrations
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IJwtProvider, JwtProvider>();
    }
}