using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LoggingMiddleware.Helpers
{
    public static class UseLoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseLogging(this IApplicationBuilder app)
        {
            app.UseMiddleware<DetailedLoggingMiddleware>();
            return app;
        }
    }
}