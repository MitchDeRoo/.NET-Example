namespace Foundation.Researchers;

public interface IResearcherService
{
    Task<IEnumerable<Researcher>> GetAll();
}