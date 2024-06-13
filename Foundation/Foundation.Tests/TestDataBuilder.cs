using Foundation.Controllers;
using Foundation.Models;

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
}