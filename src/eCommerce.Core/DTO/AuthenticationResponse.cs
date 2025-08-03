namespace eCommerce.Core.DTO;

public record AuthenticationResponse(
    Guid UserId,
    string? Email,
    string? Person,
    string? Gender,
    string? Token,
    bool Success)
{
    public AuthenticationResponse():this(Guid.Empty,null,null,null,null,false) { }
}
