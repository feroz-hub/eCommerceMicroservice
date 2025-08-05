using System.ComponentModel.DataAnnotations;

namespace eCommerce.Core.DTO;

public record LoginRequest
{
    [Required]
    [EmailAddress]
    public string? Email { get; init; }

    [Required]
    public string? Password { get; init; }
}
