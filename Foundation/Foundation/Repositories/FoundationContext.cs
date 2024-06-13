using Foundation.Models;
using Microsoft.EntityFrameworkCore;

namespace Foundation.Repositories;

public class FoundationContext : DbContext
{
    public FoundationContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Anomaly> Anomalies { get; set; }
}