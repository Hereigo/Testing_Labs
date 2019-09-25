using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using VSCode_WebAPI.Data;

namespace VSCode_WebAPI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            SeedDatabase(host);
            host.Run();
        }

        private static void SeedDatabase(IWebHost host)
        {

            var scopeFactory = host.Services.GetRequiredService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            {

                var context = scope.ServiceProvider.GetRequiredService<MyProductsContext>();

                if (context.Database.EnsureCreated())
                {
                    try
                    {
                        SeedData.Initialize(context);
                    }
                    catch (Exception ex)
                    {
                        var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
                        logger.LogError(ex, $"Seeding db exception : {ex.Message}");
                    }
                }
            }

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}