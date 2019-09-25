using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Interceptors
{
	internal static class Program
	{
		private static ServiceProvider CreateServiceProvider()
		{
			IServiceCollection serviceCollection = new ServiceCollection()
				.AddSingleton<IAuthorizationService, AuthorizationService>()
				.AddSingleton<ICacheService, CacheService>()
				.AddSingleton<ILoggerService, LoggerService>();

			ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

			return serviceProvider;
		}

		private static void Main()
		{
			ServiceProvider serviceProvider = CreateServiceProvider();
			var auth = serviceProvider.GetService<IAuthorizationService>();
			var cache = serviceProvider.GetService<ICacheService>();
			var logs = serviceProvider.GetService<ILoggerService>();

			Order order;

			Console.WriteLine("\r\n Using DI :");
			OrderService_1_di orderService1 = new OrderService_1_di(auth, logs, cache);
			order = orderService1.GetOrder(1);

			Console.WriteLine("\r\n Using Attributes :");
			OrderService_2_aop orderService2 = new OrderService_2_aop();
			order = orderService2.GetOrder(1);

			Console.WriteLine("\r\n Using Interceptors :");
			ProxyGenerator generator = new ProxyGenerator();
			IOrderService orderService3 = (IOrderService)generator.CreateClassProxy(typeof(OrderService_3_interC), new LoggingInterceptor());
			order = orderService3.GetOrder(1);

			Console.WriteLine("\r\n Done.");
		}
	}
}
