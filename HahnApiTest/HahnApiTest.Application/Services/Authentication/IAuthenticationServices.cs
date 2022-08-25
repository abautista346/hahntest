namespace HahnApiTest.Application.Services.Authentication;

public interface IAuthenticationServices
{
    AuthenticationResult Register(string firstname, string lastName, string email, string password);

    AuthenticationResult Login(string email, string password);

}