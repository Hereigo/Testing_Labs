using System;

namespace Interceptors
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	internal class AuthorizeAttribute : Attribute
	{
	}
}