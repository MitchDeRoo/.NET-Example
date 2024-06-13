using Foundation.Models;

namespace Foundation.Services;

public interface IResearcherService
{
    Task<IEnumerable<Researcher>> GetAll();
}