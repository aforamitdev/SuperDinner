namespace SuperSinner.Contracts.Authentication;

public record LoginRequest(
    string FistName,
    string LastName,
    string Email,
    string Password
    );