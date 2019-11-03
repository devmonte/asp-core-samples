using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ActionFilters.Filters.Order
{
    public class ExampleOrderResourceFilter : IResourceFilter
    {
        private readonly ILogger<ExampleOrderResourceFilter> _logger;

        public ExampleOrderResourceFilter(ILogger<ExampleOrderResourceFilter> logger)
        {
            _logger = logger;
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            _logger.LogInformation("Resource executed");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _logger.LogInformation("Before resource executing");

            //short-circuiting request
            //context.Result = new ContentResult()
            //{
            //    Content = "Resource unavailable - header not set."
            //};
        }
    }
}
