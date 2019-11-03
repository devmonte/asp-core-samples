using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ActionFilters.Filters
{
    public class ExampleAsyncActionFilter : IAsyncActionFilter
    {
        private readonly ILogger<ExampleAsyncActionFilter> _logger;

        public ExampleAsyncActionFilter(ILogger<ExampleAsyncActionFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("Before");
            await next();
            _logger.LogInformation("After");
        }
    }
}
