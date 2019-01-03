using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {

        public ExamplesController(IEnumerable<IExampleGenericService<IExampleModel>> exampleServices)
        {
            
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
