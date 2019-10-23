using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Binding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet("{id}")]
        public string UrlAndQuery(int id, string name)
        {
            return $"{id}  {name}";
        }

        [HttpGet("{name}/{id}")]    
        public string UrlAndUrl(string name, int id)
        {
            return $"{id}  {name}";
        }
    }
}