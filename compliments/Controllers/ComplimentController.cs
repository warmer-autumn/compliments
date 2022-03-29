using Microsoft.AspNetCore.Mvc;
using compliments.Services;

namespace compliments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComplimentController : ControllerBase
    {
        private readonly ILogger<ComplimentController> _logger;

        public ComplimentController(ILogger<ComplimentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCompliment")]
        //[Route ("compliment/get/{name:string}")]
        public string Get(string name)
        {

            var generator = new ComplimentGenerator(name);
            return generator.ComplimentGetString();
        }
    }
}