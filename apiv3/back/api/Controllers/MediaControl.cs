using Microsoft.AspNetCore.Mvc;
using MinhaApiJson.Models;

namespace MinhaApiJson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaControl : ControllerBase
    {
        [HttpPost]
        public IActionResult ReceberDados([FromBody] Media media)
        {
            double resultado = (media.Valor1 + media.Valor2 + media.Valor3) / 3.0;
            return Ok(new { MediaCalculada = resultado });
        }
    }
}
