using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionFilters.Filters.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        [ServiceFilter(typeof(ExampleOrderActionFilter))]
        [ServiceFilter(typeof(ExampleOrderAuthFilter))]
        [ServiceFilter(typeof(ExampleOrderExceptionFilter))]
        [ServiceFilter(typeof(ExampleOrderResourceFilter))]
        public string One() => ":)";

        [HttpGet("Two")]
        [ServiceFilter(typeof(ExampleOrderActionFilter))]
        [ServiceFilter(typeof(ExampleOrderAuthFilter))]
        [ServiceFilter(typeof(ExampleOrderExceptionFilter))]
        [ServiceFilter(typeof(ExampleOrderResourceFilter))]
        public string Two() => throw new StackOverflowException("Ups");

    }
}
