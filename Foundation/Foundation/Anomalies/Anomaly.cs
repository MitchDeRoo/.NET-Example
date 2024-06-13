using System.ComponentModel.DataAnnotations;

namespace Foundation.Anomalies;

public class Anomaly
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(30, MinimumLength = 5)]
    public string Name { get; set; }

    [Required]
    public string ObjectClass { get; set; }
    public string Description { get; set; }
}