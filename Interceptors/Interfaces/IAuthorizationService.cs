namespace Interceptors
{
	internal interface IAuthorizationService
	{
		void AssertPermission(string v);
	}
}