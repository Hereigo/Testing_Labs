using System;
using System.Threading;

namespace CODE_SNIPPETS
{
	internal static class Threads_Syncronization
	{
		// will be replaced in another thread.
		public static int sharedBetweenThreads = 111;

		// OS Windows "mutex" wrapper !
		private static readonly Mutex mutexObj = new Mutex();

		private static readonly object sharesLocker = new object();

		// OS Windows events wrapper ! - TRUE = Activated, FALSE = Disabled until TRUE.
		private static readonly AutoResetEvent waitHandler = new AutoResetEvent(true);
		// Mutex can work between Processes!

		// .Net classic example :
		// Mutex mutexObj = new Mutex(true, // Give the calling thread the ownership of the mutex if the thread is creator.
		//					Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString(), // Get App instance guid.
		//					out bool existed); // Result is - if application has started already.

		internal static void MainJob()
		{
			// FIVE ADDITIONAL THREADS :
			for (int i = 1; i < 5; i++)
			{
				// The same as	:	= new Thread(new ParameterizedThreadStart(Program.SomeJob));
				Thread Another_Thread = new Thread(SomeJob);
				Another_Thread.Start(i);
			}

			for (int i = 0; i < 15; i++)
			{
				Console.WriteLine($"Thread Main - {sharedBetweenThreads}");
				Thread.Sleep(1);
			}
		}

		private static void SomeJob(object data)
		{
			// v.1 :
			waitHandler.WaitOne();
			// AutoResetEvent.WaitAny(new WaitHandle[] {waitHandler}); - for many handlers.
			// AutoResetEvent.WaitAll(...

			// v.2 :
			mutexObj.WaitOne();

			// v.3
			lock (sharesLocker)
			{
				try
				{
					// v.4 :
					Monitor.Enter(sharesLocker);
					// also can : Monitor.Wait(); Monitor.Pulse(); Monitor.PulseAll();

					int currentData = Convert.ToInt32(data);

					sharedBetweenThreads = 10 * currentData;

					for (int i = 0; i < 15; i++)
					{
						Console.WriteLine($"Thread # {currentData} - {sharedBetweenThreads}");
						Thread.Sleep(1);
					}
				}
				finally
				{
					Monitor.Exit(sharesLocker);
				}
			}

			mutexObj.ReleaseMutex();

			waitHandler.Set();
		}
	}
}
// Shared between threads:		Shared locked with : Lock / Monitor / AutoResetEvent / Mutex

//	Thread # 4 - 40				Thread Main - 111
//	Thread # 1 - 10				Thread # 1 - 10
//	Thread # 3 - 30				Thread # 1 - 10
//	Thread Main - 111			Thread Main - 10
//	Thread # 2 - 20				Thread # 1 - 10      
//	Thread Main - 40				...                       
//	Thread # 1 - 40				Thread # 1 - 10           
//	Thread # 3 - 40				Thread Main - 10          
//	Thread # 2 - 40				Thread # 4 - 40           
//	Thread # 4 - 40				Thread # 4 - 40           
//	Thread Main - 40				...                       
//	Thread # 3 - 40				Thread # 4 - 40           
//	...							Thread # 2 - 20
//								Thread # 2 - 20
//								...
//								Thread # 2 - 20
//								Thread # 3 - 30           
//								Thread # 3 - 30
//								...
//								Thread # 3 - 30
