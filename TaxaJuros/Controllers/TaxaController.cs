using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaxaJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaController : ControllerBase
    {
        [HttpGet]
        public double get()
        {
            return 0.01;
        }
    }
}
