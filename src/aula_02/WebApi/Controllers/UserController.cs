using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet(Name = "GetDate")]
    public IActionResult Get()
    {
        var obj = new {
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString()
        };

        return Ok(obj);
    }

    [HttpGet("Macu")]
    public IActionResult GetMacu()
    {
        var obj = new {
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString(),
            Macu = "Macu"
        };

        return Ok(obj);
    }
    [HttpGet("apresentar/{nome}")]
    public IActionResult Apresentar(string nome)
    {
        var message = $"Olha que legal, {nome}!";

        return Ok(message);
    }
}
