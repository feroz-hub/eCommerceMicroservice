using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Infrastructure.Repositories;

internal class UserRepository(ApplicationUserDbContext applicationUser):IUserRepository
{
    // public async Task<ApplicationUser?> AddUser(ApplicationUser user)
    // {
    //     // Generate a new UserId for the user
    //     user.Id = Guid.NewGuid();
    //    // var newUser =  applicationUser.ApplicationUsers.Add(user);
    //     // Save changes to the database
    //     await applicationUser.SaveChangesAsync();
    //     // Return the added user
    //     var newUser = new ApplicationUser()
    //     {
    //         UserId = user.UserId,
    //         Email = user.Email,
    //         Password = user.Password, // In a real application, ensure to hash the password
    //         PersonName = user.PersonName,
    //     };
    //         
    //     return newUser;
    // }

    public async Task<ApplicationUser?> AddUser(ApplicationUser user)
    {
        throw new NotImplementedException();
    }

    public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
    {
        throw new NotImplementedException();
    }

    // public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
    // {
    //     //var user = await applicationUser.ApplicationUsers.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
    //     //return dummy user;
    //     var user = new ApplicationUser()
    //     {
    //         UserId = Guid.NewGuid(),
    //         Email = email,
    //         Password = password,
    //         PersonName = "Dummy User",
    //     };
    //     
    //     return user;
    // }
}