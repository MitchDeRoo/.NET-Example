namespace Foundation.Researchers;

public class ResearcherService : IResearcherService
{
    private readonly IResearcherRepository _repository;

    public ResearcherService(IResearcherRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Researcher>> GetAll()
    {
        return await _repository.GetAll();
    }
}