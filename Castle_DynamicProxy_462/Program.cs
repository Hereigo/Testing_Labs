using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Castle_DynamicProxy_462
{
	internal static class Program
	{
		private static void Main()
		{
			WindsorContainer container = new WindsorContainer();

			container.Register(Component.For<LoggingInterceptor>().LifeStyle.Singleton);

			container.Register(Component.For<IWorker>().ImplementedBy<Worker>().Interceptors(typeof(LoggingInterceptor)));

			IWorker myTest = container.Resolve<IWorker>();

			myTest.AMethod(3.1415926535); // to interface (interceptor!)

			System.Console.WriteLine();
		}
	}
}