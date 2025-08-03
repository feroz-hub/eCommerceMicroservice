using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.Core.Services;

public class UsersService(IUserRepository userRepository,IMapper mapper) : IUsersService
{
    public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
    {
        
        var user = await userRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);
        return user == null
            ? null
            : // User not found
            mapper.Map<AuthenticationResponse>(user)with
            {
                Success = true,
                Token = "dummy-jwt-token"
            };

    }

    public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
    {
        // // Create a new ApplicationUser object from RegisterRequest
        // var newUser = new ApplicationUser
        // {
        //     Email = registerRequest.Email,
        //     Password = registerRequest.Password, // In a real application, ensure to hash the password
        //     PersonName = registerRequest.PersonName,
        //     Gender = nameof(GenderOption.Male)
        // };
        var newUser = mapper.Map<ApplicationUser>(registerRequest);
        // Add the new user to the repository
        var addedUser = await userRepository.AddUser(newUser);
        return addedUser == null
            ? null
            : // User isn't added successfully
            mapper.Map<AuthenticationResponse>(addedUser);

    }
}