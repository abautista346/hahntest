using Microsoft.AspNetCore.Mvc;
using HahnApiTest.Contracts.Authentication;
using HahnApiTest.Application.Services.Authentication;

namespace HahnApiTest.Api.Controllers;


[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{

    private AuthenticationServices Authenticati= new AuthenticationServices();

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {  
        var authResukt = Authenticati.Register(
            request.firstName, 
            request.lastName, 
            request.email,
            request.password);

        var response = new AuthenticationResponse(
            authResukt.id,
            authResukt.firstName,
            authResukt.lastName,
            authResukt.email,
            authResukt.token);
        

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {

        var authResult = Authenticati.Login(
            request.email,
            request.password);

        var response = new AuthenticationResponse(
            authResult.id,
            authResult.firstName,
            authResult.lastName,
            authResult.email,
            authResult.token);

        return Ok(response);
    }
}