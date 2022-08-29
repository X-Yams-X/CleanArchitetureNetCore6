using Microsoft.AspNetCore.Mvc;

namespace ClearArchitecture.Api.Controllers;

[ApiController]
[Route("Client")]
public class ClientController : ControllerBase
{
    [HttpGet("listClient")]
    public IActionResult GetListClient()
    {
        return Ok("Todo -- OK !!!");
    }
}
