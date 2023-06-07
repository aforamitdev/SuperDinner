
using SupperDinner.Application.Services;
using SuperDinner.Api.Controllers;
using SupperDinner.Application.Common.Interface.Authentication;


namespace SupperDinner.Application.Services.Authentication;
public class AuthenticationService:IAuthenticationService
{

    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string email, string password)
    {
      
        return new AuthenticationResult(Guid.NewGuid(), "firstNAme", "lastName", email, "token");
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        Guid userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
        Console.Write("---------------------CCC-----------------");
        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, token);
    }
}