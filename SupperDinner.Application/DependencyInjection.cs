using Microsoft.Extensions.DependencyInjection;
using SupperDinner.Application.Services.Authentication;

namespace SupperDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}