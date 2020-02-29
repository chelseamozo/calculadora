using Microsoft.AspNetCore.Mvc;

namespace Webapicalculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {

        }
        [Route("Multiply")]
        [HttpPost]
        public int Multiply([FromHeader]int a, [FromHeader] int b, int c)
        {
            return a * b; 
        }
        [Route("Multiply")]
        [HttpGet]
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
