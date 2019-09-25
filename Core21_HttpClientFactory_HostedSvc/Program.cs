using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Core21_HttpClientFactory_HostedSvc
{
	static class Program
	{
		static void Main(string[] args)
		{
			IHost host = new HostBuilder()
				.ConfigureAppConfiguration((context, builder) =>
				{
					string env = context.HostingEnvironment.EnvironmentName;

					builder.SetBasePath(Directory.GetCurrentDirectory())
						.AddJsonFile("appsettings.json", optional: true)
						.AddJsonFile($"appsettings.{env}.json", optional: true)
						.AddEnvironmentVariables();
				})
				.ConfigureServices(ConfigureServices)
				.UseConsoleLifetime()
				.Build();

			host.Run();
		}

		private static void ConfigureServices(IServiceCollection serviceCollection)
		{
			serviceCollection.AddHttpClient();

			serviceCollection.AddHostedService<HttpClientSvcAsBackground>();
		}
	}
}
