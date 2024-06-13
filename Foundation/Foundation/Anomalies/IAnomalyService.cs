namespace Foundation.Anomalies;

public interface IAnomalyService
{
    Task<IEnumerable<Anomaly>> GetAll();
    Task<Anomaly> GetById(Guid guid);
}