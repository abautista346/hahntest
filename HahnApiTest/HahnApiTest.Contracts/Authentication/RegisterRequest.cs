namespace HahnApiTest.Contracts.Authentication;

public record RegisterRequest(
    string firstName,
    string lastName,
    string email,
    string password);

