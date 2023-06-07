using Microsoft.Extensions.DependencyInjection;
using SuperDinner.Infrastructure.Authentication;
using SuperDinner.Infrastructure.Services;
using SupperDinner.Application.Common.Interface.Authentication;
using SupperDinner.Application.Common.Services;

namespace SuperDinner.Infrastructure;

public static  class DependencyInjections
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,Microsoft.Extensions.Configuration.ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}