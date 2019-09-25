using System;

namespace CODE_SNIPPETS
{
	internal class NetFrwk_AddDomainMonitoring
	{
		// Avaible in .Net Framework Classic Only !

		public void UsingMonitoring()
		{
			// MONITORING CPU & MEMORY USAGE :
			AppDomain.MonitoringIsEnabled = true;

			// Run Monitored Job here:
			for (int i = 0; i < 1000; i++)
			{
				Console.WriteLine(DateTime.Now.ToLongDateString());
			}

			// MONITORING CPU & MEMORY USAGE SUMMARY :
			Console.WriteLine("333:");
			Console.WriteLine($"Took: {AppDomain.CurrentDomain.MonitoringTotalProcessorTime.TotalMilliseconds:#,###} ms");
			Console.WriteLine($"Allocated: {AppDomain.CurrentDomain.MonitoringTotalAllocatedMemorySize / 1024:#,#} kb");
			Console.WriteLine($"Peak Working Set: {System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64 / 1024:#,#} kb");

			for (int index = 0; index <= GC.MaxGeneration; index++)
			{
				Console.WriteLine($"Gen {index} collections: {GC.CollectionCount(index)}");
			}
		}
	}
}