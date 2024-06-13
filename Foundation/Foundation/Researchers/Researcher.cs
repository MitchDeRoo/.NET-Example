using System.ComponentModel.DataAnnotations;
using Foundation.Anomalies;

namespace Foundation.Researchers;

public class Researcher
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(30, MinimumLength = 2)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(30, MinimumLength = 2)]
    public string LastName { get; set; }

    public List<Anomaly> Studies { get; set; }
}