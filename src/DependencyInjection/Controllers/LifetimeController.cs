using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifetimeController : ControllerBase
    {
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;
        private readonly ISuperService _superService;

        public LifetimeController(ITransientService transientService, IScopedService scopedService, 
            ISingletonService singletonService, ISuperService superService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
            _superService = superService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(":)");
        }

        [HttpGet("singleton")]
        public IActionResult GetSingletonValue()
        {
            return Ok(_singletonService.GenerateId() + _superService.GenerateValue());
        }

        [HttpGet("scoped")]
        public IActionResult GetScopedValue()
        {
            return Ok(_scopedService.GenerateId() + _superService.GenerateValue());
        }

        [HttpGet("transient")]
        public IActionResult GetTransientValue()
        {
            return Ok(_transientService.GenerateId() + _superService.GenerateValue());
        }

    }
}
