using Microsoft.AspNetCore.Mvc;

namespace CalculoJurosComposto.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public ActionResult ShowMetheCode()
        {
            return Ok("https://github.com/MCaurrinhosJr/CalculoJurosComposto");
        }
    }
}
