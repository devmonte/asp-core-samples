using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using SUT.Services;

namespace SUT.IntegrationTests
{
    public class CustomFactory<TSartup> : WebApplicationFactory<TSartup> where TSartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == 
                         typeof(IExampleService));

                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                services.AddScoped<IExampleService, ServiceMock>();
            });
        }
    }
}
