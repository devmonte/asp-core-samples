using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Configuration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly ILogger<ConfigurationController> _logger;
        private readonly IConfiguration _configuration;

        public ConfigurationController(ILogger<ConfigurationController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet("/config")]
        public string GetConfig()
        {
            var location = _configuration["Location"];
            var starship = new Starship();
            _configuration.GetSection("starship").Bind(starship);
            var fromMemory = _configuration.GetSection("array");
            return $"Location: {location}, starship: {starship.Name}, array: {fromMemory.GetSection("entries").GetSection("0").Value}";
        }

        [HttpGet("/envconfig")]
        public string GetEnvConfig()
        {

            var fromDevSetting = _configuration["Nadpisana"];
            var fromSetting = _configuration["NieNadpisana"];

            var env = _configuration["Environment"];
            var secret = _configuration["SECRET"];
            var userSecret = _configuration["VarFromSecret"];

            return $"Env: {env}"; 
        }
    }
}
