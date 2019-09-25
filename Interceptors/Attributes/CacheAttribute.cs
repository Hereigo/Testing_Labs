using System;

namespace Interceptors
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	internal class CacheAttribute : Attribute
	{
		private readonly string v;

		public CacheAttribute(string v)
		{
			this.v = v;
		}
	}
}