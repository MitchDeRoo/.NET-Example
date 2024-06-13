using Foundation.Models;
using Foundation.Repositories;

namespace Foundation.Services;

public class AnomalyService(IAnomalyRepository repository) : IAnomalyService
{
    public Task<IEnumerable<Anomaly>> GetAll() => repository.GetAll();
}