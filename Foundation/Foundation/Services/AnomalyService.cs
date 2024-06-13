using Foundation.Controllers;

namespace Foundation.Services;

public class AnomalyService : IAnomalyService
{
    private readonly List<Anomaly> _anomalies = [
        new Anomaly 
        {
            Id = new Guid("f0fafed8-daaf-4960-9f8d-a5b7e4006b3b"),
            Name = "SCP-173",
            ObjectClass = "Euclid",
            Description = "Statue made of rebar, concrete and spray paint"
        },
        new Anomaly
        {
            Id = new Guid("bbd0faaa-b6bb-44da-a6f5-20a9c0235afe"),
            Name = "SCP-999",
            ObjectClass = "Safe",
            Description = "Cute orange-yellow slime made of happiness"
        },
        new Anomaly {
            Id = new Guid("276a8dfc-332e-402a-b20e-e7f348b827b4"),
            Name = "SCP-682",
            ObjectClass = "Keter",
            Description = "Hard To Destroy Reptile"
        }
    ];

    public List<Anomaly> GetAll() => _anomalies;
}