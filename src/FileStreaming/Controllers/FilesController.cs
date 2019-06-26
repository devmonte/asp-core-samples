using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FileStreaming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var fileStream = new FileStream(@".\testFile.aira", FileMode.Open);
            return new FileStreamResult(fileStream, "application/octet-stream");
        }
    }
}
