using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CustomMiddleware
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var cultureQuery = context.Request.Query["date"];
            if (!string.IsNullOrWhiteSpace(cultureQuery))
            {
                await context.Response.WriteAsync($"\n Current date {DateTime.Now}");
                return;
            }
            await _next(context);
        }
    }
}
