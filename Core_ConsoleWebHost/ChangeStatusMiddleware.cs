using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Core21_ConsoleWebHost
{
	internal class ChangeStatusMiddleware
	{
		private readonly RequestDelegate _next;

		public ChangeStatusMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			// Do something with context near the beginning of request processing.
			context.Response.StatusCode = 400; // =)

			await _next.Invoke(context).ConfigureAwait(false);

			// Clean up.
		}
	}

	public static class MyMiddlewareExtensions
	{
		public static IApplicationBuilder UseMyOwnMiddleware(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<ChangeStatusMiddleware>();
		}
	}
}