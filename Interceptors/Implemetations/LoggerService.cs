using System;

namespace Interceptors
{
	public class LoggerService : ILoggerService
	{
		public void LogInfo(string v, int orderID)
		{
			Console.WriteLine("logging...");
		}
	}
}
