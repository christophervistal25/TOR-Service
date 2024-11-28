using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TOR.API.Models;

namespace TOR.API.Data;

public class ApplicationDBContext : IdentityDbContext<User>
{
    public ApplicationDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
    {
        
    }    
    
    
    public DbSet<Stock?> Stocks { get; set; }
    
    public DbSet<User>  Users { get; set; }
    
    public DbSet<Municipality>  Municipalities { get; set; }
    
    public DbSet<Establishment>  Establishments { get; set; }
    
    public DbSet<AccomodationClassification> AccomodationClassifications { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        List<IdentityRole> roles = new List<IdentityRole>
        {
            new() {Name = "Admin", NormalizedName = "ADMIN"},
            new() {Name = "User", NormalizedName = "USER"}
        };
        
        builder.Entity<IdentityRole>().HasData(roles);
    }

}