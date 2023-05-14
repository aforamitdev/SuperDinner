using Microsoft.Extensions.DependencyInjection;
using SuperDinner.Application.Servcies.Authentication;

namespace SuperDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}