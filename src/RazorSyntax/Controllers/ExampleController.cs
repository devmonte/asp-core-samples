using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorSyntax.Models;

namespace RazorSyntax.Controllers
{
    public class ExampleController : Controller
    {
        private readonly ILogger<ExampleController> _logger;

        public ExampleController(ILogger<ExampleController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Student"] = new Student { Age = 25, College = "UTP", Name = "John" };
            return View();
        }

        public IActionResult IfStatement()
        {
            ViewBag.IsMonday = false;
            return View();
        }

        public IActionResult ForEachLoop()
        {

            var list = new List<Student>
            {
                new Student { Age = 25, College = "UTP", Name = "John1" },
                new Student { Age = 25, College = "WSG", Name = "John2" },
                new Student { Age = 26, College = "UKW", Name = "John3" },
                new Student { Age = 28, College = "UMK", Name = "John4" }

            };
            return View(list);
        }

    }
}
