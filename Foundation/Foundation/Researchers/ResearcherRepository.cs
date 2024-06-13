using Foundation.Anomalies;
using Microsoft.EntityFrameworkCore;

namespace Foundation.Researchers;

public class ResearcherRepository : IResearcherRepository
{
    private FoundationContext _context;

    public ResearcherRepository(FoundationContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Researcher>> GetAll()
    {
        return await _context.Researchers.ToListAsync();
    }

    public async Task<Researcher?> Get(Guid id)
    {
        return await _context.Researchers.FindAsync(id);
    }

    public async Task<Researcher> Add(Researcher entity)
    {
        _context.Researchers.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Researcher> Update(Researcher entity)
    {
        _context.Researchers.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Researcher> Delete(Guid id)
    {
        var entity = await _context.Researchers.FindAsync(id);
        if (entity == null)
        {
            return null;
        }

        _context.Researchers.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}