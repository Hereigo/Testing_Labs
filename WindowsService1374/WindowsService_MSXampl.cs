using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Timers;

namespace WindowsService_MSXampl
{
	public partial class WindowsService_MSXampl : ServiceBase
	{
		private int eventId = 1;

		public WindowsService_MSXampl()
		{
			InitializeComponent();

			eventLog1 = new System.Diagnostics.EventLog();

			if (!System.Diagnostics.EventLog.SourceExists("MySource"))
			{
				System.Diagnostics.EventLog.CreateEventSource(
					"MySource", "MyNewLog");
			}

			eventLog1.Source = "MySource";

			eventLog1.Log = "MyNewLog";
		}

		protected override void OnStart(string[] args)
		{
			eventLog1.WriteEntry("WS-1374 In OnStart.");

			// Set up a timer that triggers every minute.
			Timer timer = new Timer();
			timer.Interval = 60000; // 60 seconds
			timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
			timer.Start();
		}

		public void OnTimer(object sender, ElapsedEventArgs args)
		{
			// TODO: Insert monitoring activities here.
			eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
		}

		protected override void OnStop()
		{
			eventLog1.WriteEntry("WS-1374 In OnStop.");
		}

		protected override void OnContinue()
		{
			eventLog1.WriteEntry("In OnContinue.");
		}

		public enum ServiceState
		{
			SERVICE_STOPPED = 0x00000001,
			SERVICE_START_PENDING = 0x00000002,
			SERVICE_STOP_PENDING = 0x00000003,
			SERVICE_RUNNING = 0x00000004,
			SERVICE_CONTINUE_PENDING = 0x00000005,
			SERVICE_PAUSE_PENDING = 0x00000006,
			SERVICE_PAUSED = 0x00000007,
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct ServiceStatus
		{
			public int dwServiceType;
			public ServiceState dwCurrentState;
			public int dwControlsAccepted;
			public int dwWin32ExitCode;
			public int dwServiceSpecificExitCode;
			public int dwCheckPoint;
			public int dwWaitHint;
		};
	}
}
