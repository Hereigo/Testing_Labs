using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core21_ConsoleWebHost
{
	public class CounterMiddleware
	{
		private readonly RequestDelegate _aspHttpRequestDelegate;

		private int cnt;

		public CounterMiddleware(RequestDelegate request)
		{
			_aspHttpRequestDelegate = request;
		}

		public async Task Invoke(HttpContext httpContext, ICounterService counterService, CounterServiceFactory serviceFactory)
		{
			cnt++;

			httpContext.Response.ContentType = "text/html;charset=utf-8";

			await httpContext.Response.WriteAsync(
				$"Request #{cnt} - CountSvc: {counterService.GetVal} - SvcFactory: {serviceFactory._counterSercive.GetVal}")
				.ConfigureAwait(false);
		}
	}
}