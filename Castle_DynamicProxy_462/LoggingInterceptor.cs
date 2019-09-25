using Castle.Core;
using Castle.Core.Interceptor;
using Castle.DynamicProxy;
using System;

namespace Castle_DynamicProxy_462
{
	public class LoggingInterceptor : IInterceptor, IOnBehalfAware // to define a ComponentModel.Implementation.FullName
	{
		private string _interceptedModelName;
		private string _invocationMethod;
		private string _methodArguments;

		public void Intercept(IInvocation invocation)
		{
			_invocationMethod = invocation.Method?.Name ?? "[on interface target]";

			_methodArguments = GetInvocationMethodArgs(invocation.Arguments);

			Console.WriteLine($"Before invocation - {_interceptedModelName}.{_invocationMethod}() with args: {_methodArguments}");
			invocation.Proceed(); // Worker.AMethod() execution.
			Console.WriteLine($"After invocation - Return value - {invocation.ReturnValue}");
		}

		private string GetInvocationMethodArgs(object[] arguments)
		{
			int argumentsCount = arguments.Length;

			if (argumentsCount == 0)
			{
				return "[no args]";
			}
			else
			{
				string[] args = new string[argumentsCount];

				for (int i = 0; i < args.Length; i++)
				{
					args[i] = arguments[i].ToString();
				}

				return string.Join(", ", args);
			}
		}

		// Is using by IOnBehalfAware.
		public void SetInterceptedComponentModel(ComponentModel target)
		{
			if (target != null)
				_interceptedModelName = target.Implementation.FullName;
		}
	}
}
