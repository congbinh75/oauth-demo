using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OAuthDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("public")]
    public IActionResult GetPublicProducts()
    {
        return Ok("This is a public endpoint accessible without authentication.");
    }
    
    [Authorize]
    [HttpGet("private")]
    public IActionResult GetPrivateProducts()
    {
        return Ok("This is a private endpoint accessible only with valid authentication.");
    }
}