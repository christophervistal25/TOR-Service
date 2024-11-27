using Microsoft.EntityFrameworkCore;
using TOR.API.Models;

namespace TOR.API.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
    {
        
    }    
    
    
    public DbSet<Stock?> Stocks { get; set; }
    
    public DbSet<User>  Users { get; set; }
    
    public DbSet<Municipality>  Municipalities { get; set; }
    
    public DbSet<Establishment>  Establishments { get; set; }
    
    public DbSet<AccomodationClassification> AccomodationClassifications { get; set; }
    
}