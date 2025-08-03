using Microsoft.EntityFrameworkCore;

namespace eCommerce.Core.Entities;

public class ApplicationUserDbContext(DbContextOptions<ApplicationUserDbContext> options) : DbContext(options)
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
}