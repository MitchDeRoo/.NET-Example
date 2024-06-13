namespace Foundation.Anomalies;

public class AnomalyService(IAnomalyRepository repository) : IAnomalyService
{
    public Task<IEnumerable<Anomaly>> GetAll() => repository.GetAll();
}