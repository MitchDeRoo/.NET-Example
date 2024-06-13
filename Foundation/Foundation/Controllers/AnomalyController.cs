using Microsoft.AspNetCore.Mvc;

namespace Foundation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnomalyController : ControllerBase
{
    private readonly IAnomalyService _service;

    public AnomalyController(IAnomalyService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var items = _service.GetAll();
        return Ok(items);
    }
}