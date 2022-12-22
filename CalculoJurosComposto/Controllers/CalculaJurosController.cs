using CalculoJurosComposto.Model;
using CalculoJurosComposto.Util;
using Microsoft.AspNetCore.Mvc;

namespace CalculoJurosComposto.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult> CalculaJurosAsync(double valorinicial, int meses)
        {
            double juros = await ApiHelper.GetAsync("Taxa");
                        
            double result = valorinicial * Math.Pow((1 + juros), meses);

            return Ok(result.ToString("N2"));
        }

        [HttpPost]
        public async Task<ActionResult> CalculaJurosAsync(BaseCalculo valores)
        {
            double juros = await ApiHelper.GetAsync("Taxa");

            double result = valores.ValorInicial * Math.Pow((1 + juros), valores.Meses);

            return Ok(result.ToString("N2"));
        }
    }
}
