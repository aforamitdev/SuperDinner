using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SupperDinner.Application.Common.Interface.Authentication;
using SupperDinner.Application.Common.Services;

namespace SuperDinner.Infrastructure.Authentication;

public class JwtTokenGenerator:IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwtSettings _jwtSettings;

    public JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettings = jwtOptions.Value;
    }

    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var signingCredentials =
            new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
                SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };
        Console.Write("----TEST----");
        var securityToken = new JwtSecurityToken(issuer: _jwtSettings.Issuer, expires: _dateTimeProvider.UtcNow.AddDays(_jwtSettings.ExpiryMinutes),
            signingCredentials: signingCredentials,claims:claims);
        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}