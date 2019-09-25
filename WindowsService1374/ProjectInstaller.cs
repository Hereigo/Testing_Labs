using System.ComponentModel;

namespace WindowsService_MSXampl
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		public ProjectInstaller()
		{
			InitializeComponent();

			this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;

			this.serviceInstaller1.Description = "WindowsService1374 Description";
			this.serviceInstaller1.DisplayName = "WindowsService1374.Name";
		}
	}
}
