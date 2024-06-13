using Microsoft.AspNetCore.Mvc;

namespace Foundation.Anomalies;

[Route("api/anomalies")]
[ApiController]
public class AnomalyController(IAnomalyService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var items = await service.GetAll();
        return Ok(items);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var anomaly = await service.GetById(id);
        if (anomaly == null)
        {
            return NotFound();
        }
        return Ok(anomaly);
    }
}