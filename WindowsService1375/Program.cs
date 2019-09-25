using System.ServiceProcess;

namespace WindowsService1375
{
	internal static class Program
	{
		private static void Main()
		{
			ServiceBase[] ServicesToRun = new ServiceBase[]
			{
				new WindowsService1375()
			};

			ServiceBase.Run(ServicesToRun);
		}
	}
}
