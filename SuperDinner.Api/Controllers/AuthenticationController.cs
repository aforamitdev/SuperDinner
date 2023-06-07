namespace SuperDinner.Api.Controllers;

using Microsoft.AspNetCore.Mvc;
using SuperDinner.Contracts;
using SupperDinner.Application.Services.Authentication;


[ApiController]
[Route("auth")]
public class AuthenticationController:ControllerBase
{

    private readonly IAuthenticationService _authenticationService;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        Console.Write(request);
        var authResult = _authenticationService.Register(request.FirstName,request.LastName,request.Email,request.Password);
        return Ok(authResult);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        
        return Ok(request);
    }

}