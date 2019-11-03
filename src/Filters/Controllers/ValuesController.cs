using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filters.Filters;
using Filters.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ServiceFilter(typeof(ActionFilterExample))]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [ServiceFilter(typeof(ValueFilter))]
        public IEnumerable<Student> Get()
        {
            return new Student[]
            {
                new Student { Age = 34 }, 
                new Student { Age = 35 },
                new Student { Age = 36 },
                new Student { Age = 37 },
                new Student { Age = 25 },
                new Student { Age = 22 }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

    }
}
