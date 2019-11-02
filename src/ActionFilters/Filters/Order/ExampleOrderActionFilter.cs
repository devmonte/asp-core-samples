using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ActionFilters.Filters.Order
{
    public class ExampleOrderActionFilter : IActionFilter
    {
        private readonly ILogger<ExampleOrderActionFilter> _logger;

        public ExampleOrderActionFilter(ILogger<ExampleOrderActionFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Action executed");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Action executing");
        }
    }
}
