namespace SuperSinner.Contracts.Authentication;

public record RegisterRequest(
    string FistName,
    string LastName,
    string Email,
    string Password
);