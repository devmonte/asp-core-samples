using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace NoStartup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.Configure(configureApp =>
                    {
                        //configureApp.UseRouting();
                        configureApp.UseEndpoints(endpoints => 
                        {
                            endpoints.MapGet("/test", context =>
                            {
                                return context.Response.WriteAsync("Hello Oponeo!");
                            });

                            endpoints.MapGet("/abc", async context =>
                            {
                                await context.Response.WriteAsync("ABC!");
                            });


                        });

                    configureApp.Use((context, midd) => context.Response.WriteAsync("TEST"));
                });
                });
    }
}
