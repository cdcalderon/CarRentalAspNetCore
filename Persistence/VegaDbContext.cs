using Microsoft.EntityFrameworkCore;
using vega2.Models;

namespace vega2.Persistence
{
    public class VegaDbContext : DbContext
    {
       public VegaDbContext(DbContextOptions<VegaDbContext> options) 
            : base(options)
       {
           
       } 

       public DbSet<Make> Makes { get; set; }
    }
}