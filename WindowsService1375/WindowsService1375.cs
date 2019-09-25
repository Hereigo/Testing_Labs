using System;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Timers;

namespace WindowsService1375
{
	public partial class WindowsService1375 : ServiceBase
	{
		public Timer Timer { get; } = new Timer();

		public WindowsService1375()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			WriteToFile(DateTime.Now + " - SERVICE IS STARTED.");
			Timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
			Timer.Interval = 30 * 60 * 1000; //number in miliseconds  
			Timer.Enabled = true;
		}

		protected override void OnStop()
		{
			WriteToFile(DateTime.Now + " - SERVICE IS STOPPED.");
		}

		private void OnElapsedTime(object source, ElapsedEventArgs e)
		{
			Process[] pname = Process.GetProcessesByName("devenv");

			if (pname.Length != 0)
				WriteToFile(DateTime.Now + " - Development.");
			else
				WriteToFile(DateTime.Now + " - Doing something else...");
		}

		public void WriteToFile(string Message)
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";

			if (!File.Exists(filepath))
			{
				// Create a file to write to.   
				using (StreamWriter sw = File.CreateText(filepath))
				{
					sw.WriteLine(Message);
				}
			}
			else
			{
				using (StreamWriter sw = File.AppendText(filepath))
				{
					sw.WriteLine(Message);
				}
			}
		}
	}
}