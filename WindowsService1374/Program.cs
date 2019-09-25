using System.ServiceProcess;

namespace WindowsService_MSXampl
{
	internal static class Program
	{
		private static void Main()
		{
			ServiceBase[] ServicesToRun = new ServiceBase[]
			{
				new WindowsService_MSXampl()
			};

			ServiceBase.Run(ServicesToRun);
		}
	}
}
