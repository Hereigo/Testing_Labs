using System;
using System.Threading;

namespace CODE_SNIPPETS
{
	internal static class Threads_Semaphore
	{
		internal static void MainJob()
		{
			for (int i = 0; i < 6; i++)
			{
				Visitor visitor = new Visitor(i);
			}
		}
	}

	internal class Visitor
	{
		static Semaphore semaphore = new Semaphore(3, 3);

		Thread thread;

		public Visitor(int i)
		{
			thread = new Thread(SayHello);
			thread.Name = $"Visitor-{i}";
			thread.Start();
		}

		private void SayHello(object obj)
		{
			
		}
	}
}
