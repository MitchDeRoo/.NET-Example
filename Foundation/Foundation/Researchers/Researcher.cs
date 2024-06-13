using Foundation.Anomalies;

namespace Foundation.Researchers;

public class Researcher
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Anomaly> Studies { get; set; }
}