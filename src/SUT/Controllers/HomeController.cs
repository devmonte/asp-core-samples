using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Binding.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SUT.Models;
using SUT.Services;

namespace SUT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExampleService _service;

        public HomeController(ILogger<HomeController> logger, IExampleService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Index2()
        {
            return Ok("Test");
        }

        public async Task<IActionResult> GetValue()
        {
            return Ok(_service.GetValue());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ExampleModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return BadRequest();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
