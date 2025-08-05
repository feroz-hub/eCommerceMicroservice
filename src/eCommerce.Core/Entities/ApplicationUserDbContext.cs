using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Core.Entities;

public class ApplicationUserDbContext(DbContextOptions<ApplicationUserDbContext> options) : IdentityDbContext(options)
{
    /// <summary>
    /// Gets or sets the DbSet for ApplicationUser entities.
    /// </summary>
    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
    
 
    
}