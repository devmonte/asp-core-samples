using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace GenericHost
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var defaultBuilder = Host.CreateDefaultBuilder();

            var host = defaultBuilder
                .ConfigureServices((context, collection) =>
                    {
                        collection.AddHostedService<ExampleHostedService>();
                    })
                .Build();

            await host.RunAsync();
        }
    }
}
