using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ActionFilters.Filters.Order
{
    public class ExampleOrderAuthFilter : IAuthorizationFilter
    {
        private readonly ILogger<ExampleOrderAuthFilter> _logger;

        public ExampleOrderAuthFilter(ILogger<ExampleOrderAuthFilter> logger)
        {
            _logger = logger;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _logger.LogInformation("Uuuu auth");
        }
    }
}
