namespace Foundation.Models;

public class Researcher
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Anomaly> Studies { get; set; }
}