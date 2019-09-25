using System;

namespace Core21_PubSubClient
{
	internal static class Program
	{
		private static void Main()
		{
			try
			{
				PubSub pubSub = new PubSub();

				System.Threading.Tasks.Task rez = pubSub.ClientAsync();

				rez.Wait();

			}
			catch (Exception ex)
			{
				Console.WriteLine($"ERROR: {ex.Message}");
			}
			Console.WriteLine("Hello World!");
			Console.ReadKey();
		}
	}
}
