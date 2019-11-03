using Microsoft.AspNetCore.Mvc;

namespace Areas.Example.Controllers
{
    [Area("Example")]
    public class RCLController : Controller
    {
        public IActionResult Index() => View();
    }
}
