using AuthenticationAuthorization.Infrastructure.Authentication;
using Microsoft.Extensions.Options;

namespace AuthenticationAuthorization.Api.OptionsSetup;

public class JwtOptionsSetup(IConfiguration configuration) : IConfigureOptions<JwtOptions>
{
    private const string SectionName = "Jwt";

    public void Configure(JwtOptions options)
    {
        Console.WriteLine("Test - JwtOptionsSetup");
        configuration.GetSection(SectionName).Bind(options);
    }
}