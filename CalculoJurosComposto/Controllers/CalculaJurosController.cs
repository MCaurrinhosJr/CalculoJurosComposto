using CalculoJurosComposto.Model;
using CalculoJurosComposto.Util;
using Microsoft.AspNetCore.Mvc;

namespace CalculoJurosComposto.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [Route("calculajuros")]
        [HttpPost]
        public async Task<ActionResult> CalculaJurosAsync(BaseCalculo Valores)
        {
            double juros = await ApiHelper.GetAsync("Taxa");
                        
            double result = Valores.ValorInicial * Math.Pow((1 + juros), Valores.Meses);

            return Ok(result.ToString("N2"));
        }

        [Route("ShowMeTheCode")]
        [HttpGet]
        public ActionResult ShowMetheCode()
        {
            return Ok("https://github.com/MCaurrinhosJr/CalculoJurosComposto");
        }
    }
}
