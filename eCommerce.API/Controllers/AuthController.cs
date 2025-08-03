using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(IUsersService usersService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest? registerRequest)
    {
        if (registerRequest == null)
        {
            return BadRequest("Invalid registration request.");
        }

        var response = await usersService.Register(registerRequest);
        if (response == null || response.Success == false)
        {
            return BadRequest("User registration failed.");
        }
        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest? loginRequest)
    {
        if (loginRequest == null)
        {
            return BadRequest("Invalid login request.");
        }
        var response = await usersService.Login(loginRequest);
        if (response == null || response.Success == false)
        {
            return Unauthorized("Invalid email or password.");
        }
        return Ok(response);
    }
}