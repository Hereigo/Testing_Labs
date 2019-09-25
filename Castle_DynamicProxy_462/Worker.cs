using System;

namespace Castle_DynamicProxy_462
{
	public interface IWorker
	{
		double AMethod(double a);
	}

	public class Worker : IWorker
	{
		public double AMethod(double a)
		{
			Console.WriteLine("Worker.AMethod() is working...");

			return a * 2;
		}
	}
}
