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
    public class ExampleOrderExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<ExampleOrderExceptionFilter> _logger;

        public ExampleOrderExceptionFilter(ILogger<ExampleOrderExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(":(");
            _logger.LogInformation("Uppps!!");
        }
    }
}
