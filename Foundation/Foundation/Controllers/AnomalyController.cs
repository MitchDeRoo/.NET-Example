using Foundation.Services;
using Microsoft.AspNetCore.Mvc;

namespace Foundation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnomalyController(IAnomalyService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var items = await service.GetAll();
        return Ok(items);
    }
}