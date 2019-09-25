using System;

namespace Core21_ConsoleWebHost
{
	public interface ICounterService
	{
		int GetVal { get; }
	}

	public class CounterService : ICounterService
	{
		private static readonly Random rnd = new Random();

		public CounterService()
		{
			GetVal = rnd.Next(1, 1000000);
		}

		public int GetVal { get; }
	}
}
