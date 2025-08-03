using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositoryContracts;

public interface IUserRepository
{
    /// <summary>
    /// Method to add a new user to the repository.
    /// This method takes an ApplicationUser object as a parameter and returns the added user.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<ApplicationUser?> AddUser(ApplicationUser user);
    /// <summary>
    /// Method to get a user by their email and password.
    /// This method takes an email and password as parameters and returns the user if found.
    /// If no user is found, it returns null.
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
}