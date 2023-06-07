namespace SuperDinner.Contracts;

public record RegisterRequest(
    Guid id, string FirstName,string LastName,string Email,string Password
    );