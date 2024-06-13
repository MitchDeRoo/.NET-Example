namespace Foundation.Controllers;

public interface IAnomalyService
{
    Task<List<Anomaly>> GetAll();
}