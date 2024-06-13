namespace Foundation.Anomalies;

public class AnomalyService(IAnomalyRepository repository) : IAnomalyService
{
    public Task<IEnumerable<Anomaly>> GetAll() => repository.GetAll();
    public Task<Anomaly> GetById(Guid guid) => repository.Get(guid);
}