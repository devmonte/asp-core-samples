using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters.Filters
{
    public class ActionFilterExample : IActionFilter
    {
        private readonly ILogger<ActionFilterExample> _logger;

        public ActionFilterExample(ILogger<ActionFilterExample> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogDebug($"Status code: {context.HttpContext.Response.StatusCode}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogDebug($"Route data: {context.RouteData}");
        }
    }
}
