using System.ComponentModel.DataAnnotations;

namespace eCommerce.Core.Entities;
/// <summary>
/// Defines the ApplicationUser class, which acts as entity model class to store user details in data store.
/// This class is used to represent a user in the eCommerce application.
/// </summary>
public class ApplicationUser
{
    [Key]
    public Guid UserId { get; set; }
    [EmailAddress]
    [StringLength(40)]
    public string? Email { get; set; }
    [StringLength(20)]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    [StringLength(50)]
    [Required]
    public string? PersonName { get; set; }
    [StringLength(10)]
    public string? Gender { get; set; }
}