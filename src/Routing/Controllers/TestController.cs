using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routing.Models;

namespace Routing.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        public string FirstTestAction()
        {
            return "First action";
        }

        public string SecondTestAction()
        {
            return "Second action";
        }

        public string ThirdTestAction()
        {
            return "Third action";
        }
    }
}
