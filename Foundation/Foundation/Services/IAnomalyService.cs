using Foundation.Models;

namespace Foundation.Services;

public interface IAnomalyService
{
    Task<IEnumerable<Anomaly>> GetAll();
}