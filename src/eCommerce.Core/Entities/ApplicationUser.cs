using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace eCommerce.Core.Entities;
/// <summary>
/// Defines the ApplicationUser class, which acts as entity model class to store user details in data store.
/// This class is used to represent a user in the eCommerce application.
/// </summary>
public class ApplicationUser:IdentityUser
{
   
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    [StringLength(10)]
    public string? Gender { get; set; }
}