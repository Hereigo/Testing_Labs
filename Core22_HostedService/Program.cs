namespace Core22_HostedService
{
	using System;
	using System.Threading;
	using System.Threading.Tasks;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Hosting;
	using Microsoft.Extensions.Logging;

	internal static class Program
	{
		public static void Main()
		{
			IHost host = new HostBuilder()
				.ConfigureAppConfiguration((config) => config.AddJsonFile("appsettings.json", optional: true))
				.ConfigureHostConfiguration(config => config.AddEnvironmentVariables())
				.ConfigureLogging((config) => config.AddConsole())
				.ConfigureServices((services) =>
				{
					services.AddLogging();
					// services.AddHostedService<MyBackgroundService>();
					services.AddHostedService<MyHostedService>();
				})
				.UseConsoleLifetime()
				.Build();

			host.Run();
		}
	}
	// BACKGROUNG SERVICE :
	internal class MyBackgroundService : BackgroundService
	{
		private readonly ILogger _logger;
		private readonly int seconds = 5;

		public MyBackgroundService(ILogger<MyBackgroundService> logger)
		{
			_logger = logger;
		}

		protected override Task ExecuteAsync(CancellationToken stoppingToken)
		{
			_logger.LogInformation("Svc has started.");
			// start repeater in loop :
			Timer timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(seconds));
			return Task.CompletedTask;
		}

		private void DoWork(object state)
		{
			_logger.LogInformation("Svc start to WORK.");
			Some_LongTerm_Process();
			_logger.LogInformation("Svc end to WORK.");
		}

		private void Some_LongTerm_Process()
		{
			Thread.Sleep(seconds * 1000);
			_logger.LogInformation($"Svc WORK taken {seconds} seconds.");
		}
	}
	// HOSTED SERVICE :
	internal class MyHostedService : IHostedService, IDisposable
	{
		private readonly ILogger _logger;
		private readonly int seconds = 3;
		private Timer _timer;

		public MyHostedService(ILogger<MyHostedService> logger)
		{
			_logger = logger;
		}

		public void Dispose()
		{
			_logger.LogInformation("Svc is Disposed.");
			_timer?.Dispose();
		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			_logger.LogInformation("Svc has started.");
			// start repeater in loop :
			_timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(seconds));
			return Task.CompletedTask;
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			_logger.LogInformation("Svc is stopping.");
			_timer?.Change(Timeout.Infinite, 0);
			return Task.CompletedTask;
		}

		private void DoWork(object state)
		{
			_logger.LogInformation("Svc start to WORK.");
			Some_LongTerm_Process();
			_logger.LogInformation("Svc end to WORK.");
		}

		private void Some_LongTerm_Process()
		{
			Thread.Sleep(seconds * 1000);

			if (DateTime.Now.Second % 3 == 0)
			{
				_timer?.Change(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(7));
			}
			_logger.LogInformation($"Svc WORK taken {seconds} seconds.");
		}
	}
}
// B - Svc has started.
// H - Svc has started.
// B - Svc start to WORK.
// H - Svc start to WORK.
// B - Svc WORK taken 5 seconds.
// B - Svc end to WORK.
// H - Svc WORK taken 5 seconds.
// H - Svc end to WORK.
// H - Svc start to WORK.
// B - Svc start to WORK.
// - Ctrl+C pressed :
// H - Svc is stopping.
// H - Svc is Disposed.