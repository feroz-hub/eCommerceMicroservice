using System.Security.Claims;
using eCommerce.Core.Entities;
using Microsoft.Extensions.Configuration;

namespace eCommerce.Core.Services;

public class TokenService(IConfiguration configuration)
{
    public string  CreateToken(ApplicationUser user, IList<string> roles)
    {
        // Implementation for creating a JWT token using user information and roles
        // This is a placeholder implementation, actual implementation will depend on the JWT library used
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Email, user.Email ?? string.Empty)
           // new Claim(ClaimTypes.Name, user.UserName ?? string.Empty)
        };
        return "GeneratedToken"; // Replace it with actual token generation logic
    }
    
}