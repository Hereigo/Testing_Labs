using App.Metrics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace AppMetrics_Use
{
    internal static class Program
    {
        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging();
            serviceCollection.AddHostedService<MyHostedSvc>();
        }

        private static async Task Main()
        {
            IHost host = new HostBuilder()
                .ConfigureServices(ConfigureServices)
                .UseConsoleLifetime()
                .Build();

            await host.RunAsync();
        }
    }
}