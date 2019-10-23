using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Binding.Models;
using Binding.Services;

namespace Binding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        [BindProperty(Name = "prop", SupportsGet = true)]
        public int ExampleProperty { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromServices] IExampleService exampleService)
        {
            var value = exampleService.GetExampleValue();
            return View();
        }

        public string ExamplePost([Bind("ExampleInt, ExampleString")]ExampleModel exampleModel)
        {
            return exampleModel.ExampleString;
        }

        [HttpPost]
        public string Test([FromForm] ExampleModel exampleModel)
        {
            return exampleModel.ExampleString;
        }

        public string QueryBinding(int num, string name)
        {
            return $"{num}  {name}";
        }

        [HttpGet("{id}")] //https://localhost:44373/5?name=test&prop=666
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
