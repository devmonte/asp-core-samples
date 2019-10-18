using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Binding.Models;

namespace Binding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        [BindProperty]
        public int ExampleProperty { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost(Name = "Example")]
        public string ExamplePost([FromForm] ExampleModel exampleModel)
        {
            return exampleModel.ExampleString;
        }
    }
}
