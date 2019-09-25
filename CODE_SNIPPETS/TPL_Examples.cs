using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CODE_SNIPPETS
{
	internal class TPL_Examples
	{
		private readonly int _msDelay;

		public TPL_Examples(int msDelay)
		{
			_msDelay = msDelay;
		}

		internal void Parallel_Invoke(string method)
		{
			Console.WriteLine($"\r\n Three methods started as - {method}");
			Stopwatch watch = Stopwatch.StartNew();

			Parallel.Invoke(() => LongTimeWork1(method), () => LongTimeWork2(method), () => LongTimeWork3(method));

			watch.Stop();
			Console.WriteLine($"{method} took (milliseconds) : {watch.ElapsedMilliseconds}");
		}

		internal void Task_Run(string method)
		{
			Console.WriteLine($"\r\n Three methods started as - {method}");
			Stopwatch watch = Stopwatch.StartNew();

			Task<int> task1 = Task.Run(() => LongTimeWork1(method));
			Task<int> task2 = Task.Run(() => LongTimeWork2(method));
			Task<int> task3 = Task.Run(() => LongTimeWork3(method));

			int rez1 = task1.Result;
			int rez2 = task2.Result;
			int rez3 = task3.Result;

			watch.Stop();
			Console.WriteLine($"{method} took (milliseconds) : {watch.ElapsedMilliseconds}");
		}

		internal void Task_Run_And_Forget(string method)
		{
			Console.WriteLine($"\r\n Three methods started as - {method}");
			Stopwatch watch = Stopwatch.StartNew();

			Task<int> task1 = Task.Run(() => LongTimeWork1(method));
			Task<int> task2 = Task.Run(() => LongTimeWork2(method));
			Task<int> task3 = Task.Run(() => LongTimeWork3(method));

			watch.Stop();
			Console.WriteLine($"{method} time : {watch.ElapsedMilliseconds}");
		}

		internal async Task<int> Task_Run_Async(string method)
		{
			Console.WriteLine($"\r\n Three methods started as - {method}");
			Stopwatch watch = Stopwatch.StartNew();

			int task1 = await Task.Run(() => LongTimeWork1(method));
			int task2 = await Task.Run(() => LongTimeWork2(method));
			int task3 = await Task.Run(() => LongTimeWork3(method));

			watch.Stop();
			Console.WriteLine($"{method} took (milliseconds) : {watch.ElapsedMilliseconds}");

			return task1 + task2 + task3;
		}

		// P R I V A T E   M E T H O D S  :

		private int LongTimeWork1(string method)
		{
			System.Threading.Thread.Sleep(_msDelay);
			Console.WriteLine(method + " work 1 finished.");
			return 1;
		}

		private int LongTimeWork2(string method)
		{
			System.Threading.Thread.Sleep(_msDelay);
			Console.WriteLine(method + " work 2 finished.");
			return 1;
		}

		private int LongTimeWork3(string method)
		{
			System.Threading.Thread.Sleep(_msDelay);
			Console.WriteLine(method + " work 3 finished.");
			return 1;
		}
	}
}
