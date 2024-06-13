using Foundation.Anomalies;
using Foundation.Researchers;

namespace Foundation.Tests;

public class TestDataBuilder
{
    public Anomaly CreateAnomaly(string name, string objectClass, string description)
    {
        return new Anomaly
        {
            Id = Guid.NewGuid(),
            Name = name,
            ObjectClass = objectClass,
            Description = description
        };
    }

    public IEnumerable<Anomaly> CreateTestAnomalies()
    {
        return [
            CreateAnomaly("SCP-173", "Euclid", "Statue made of rebar, concrete and spray paint"),
            CreateAnomaly("SCP-999", "Safe", "Cute orange-yellow slime made of happiness and joy"),
            CreateAnomaly("SCP-682", "Keter", "Hard To Destroy Reptile")
        ];
    }

    public IEnumerable<Researcher> CreateTestResearchers()
    {
        return
        [
            CreateResearcher("Jack", "Bright"),
            CreateResearcher("Mark", "Gears"),
        ];
    }

    public Researcher CreateResearcher(string firstName, string lastName)
    {
        return new Researcher
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
        };
    }
}