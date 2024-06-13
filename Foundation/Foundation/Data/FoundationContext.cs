using Foundation.Anomalies;
using Foundation.Researchers;
using Microsoft.EntityFrameworkCore;

namespace Foundation.Data;

public class FoundationContext : DbContext
{
    public FoundationContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Anomaly> Anomalies { get; set; }
    public DbSet<Researcher> Researchers { get; set; }
}