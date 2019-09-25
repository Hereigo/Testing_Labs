using System;

namespace Interceptors
{
	internal class LogsAttribute : Attribute
	{
		public LogsAttribute()
		{
			Console.WriteLine("LogsAttribute CREATED");
		}
	}
}