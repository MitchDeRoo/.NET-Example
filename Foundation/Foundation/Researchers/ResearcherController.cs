using Microsoft.AspNetCore.Mvc;

namespace Foundation.Researchers;

[Route("api/researchers")]
[ApiController]
public class ResearcherController(IResearcherService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var items = await service.GetAll();
        return Ok(items);
    }
}