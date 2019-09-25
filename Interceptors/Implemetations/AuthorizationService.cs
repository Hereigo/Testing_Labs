using System;

namespace Interceptors
{
	public class AuthorizationService : IAuthorizationService
	{
		public void AssertPermission(string v)
		{
			Console.WriteLine("Permition Asserted...");
		}
	}
}
