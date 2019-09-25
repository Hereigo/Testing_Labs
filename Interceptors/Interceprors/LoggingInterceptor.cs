using Castle.DynamicProxy;
using System;

namespace Interceptors
{
	public class LoggingInterceptor : IInterceptor
	{
		public void Intercept(IInvocation invocation)
		{
			if (Attribute.IsDefined(invocation.Method, typeof(LogsAttribute)))
			{
				Console.WriteLine("Method called: " + invocation.Method.Name);
			}
			else
			{
				Console.WriteLine("LoggingInterceptor");
			}

			invocation.Proceed();
		}
	}
}
