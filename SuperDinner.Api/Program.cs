using Microsoft.AspNetCore.Authentication;
using SuperDinner.Application;
using SuperDinner.Infrastructure;
using AuthenticationService = SuperDinner.Application.Servcies.Authentication.AuthenticationService;
using IAuthenticationService = SuperDinner.Application.Servcies.Authentication.IAuthenticationService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure();
    builder.Services.AddControllers();
    
}

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();

{
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}