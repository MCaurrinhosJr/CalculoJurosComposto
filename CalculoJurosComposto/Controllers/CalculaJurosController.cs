using CalculoJurosComposto.Model;
using CalculoJurosComposto.Util;
using Microsoft.AspNetCore.Mvc;

namespace CalculoJurosComposto.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        // GET CalculaJuros?valorinicial=value&meses=value2
        [HttpGet]
        public async Task<ActionResult> CalculaJurosAsync(double valorinicial, int meses)
        {
            double juros = await ApiHelper.GetAsync("Taxa");
                        
            double result = valorinicial * Math.Pow((1 + juros), meses);

            return Ok(result.ToString("N2"));
        }
    }
}
