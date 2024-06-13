using Foundation.Core;
using Microsoft.EntityFrameworkCore;

namespace Foundation.Anomalies;

public class AnomalyRepository : IAnomalyRepository
{
    private readonly FoundationContext _context;

    public AnomalyRepository(FoundationContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Anomaly>> GetAll()
    {
        return await _context.Anomalies.ToListAsync();
    }

    public async Task<Anomaly?> Get(Guid id)
    {
        return await _context.Anomalies.FindAsync(id);
    }

    public async Task<Anomaly> Add(Anomaly entity)
    {
        _context.Anomalies.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Anomaly> Update(Anomaly entity)
    {
        _context.Anomalies.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Anomaly> Delete(Guid id)
    {
        var entity = await _context.Anomalies.FindAsync(id);
        if (entity == null)
        {
            return null;
        }

        _context.Anomalies.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}