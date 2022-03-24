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
        public string Get()
        {
            var generator = new ComplimentGenerator("You are very ");
            return generator.ComplimentGetString();
        }
    }
}