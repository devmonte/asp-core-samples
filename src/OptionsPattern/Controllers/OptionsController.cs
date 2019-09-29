using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OptionsPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OptionsController : ControllerBase
    {
        private readonly ILogger<OptionsController> _logger;
        private readonly IOptionsMonitor<OptionsExample> _optionsMonitor;

        public OptionsController(ILogger<OptionsController> logger, IOptionsMonitor<OptionsExample> optionsMonitor)
        {
            _logger = logger;
            _optionsMonitor = optionsMonitor;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var integer = _optionsMonitor.CurrentValue.SomeInteger;
            var someString = _optionsMonitor.CurrentValue.SomeString;
            return Ok(someString);
        }
    }
}
