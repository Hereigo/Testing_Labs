using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace WindowsService1375
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		public ProjectInstaller()
		{
			InitializeComponent();

			this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;


			this.serviceInstaller1.Description = "WindowsService1375 Description";
			this.serviceInstaller1.DisplayName = "WindowsService1375.Name";

			// Autostart after install :
			this.AfterInstall += new InstallEventHandler(ServiceInstaller_AfterInstall);
		}

		void ServiceInstaller_AfterInstall(object sender, InstallEventArgs e)
		{
			using (ServiceController sc = new ServiceController(serviceInstaller1.ServiceName))
			{
				sc.Start();
			}
		}
	}
}
