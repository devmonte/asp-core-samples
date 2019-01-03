using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace GenericHost
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .Build();

            await host.RunAsync();
        }
    }
}
