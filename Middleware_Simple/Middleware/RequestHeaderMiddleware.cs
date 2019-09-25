using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware_Simple.Middleware
{
    public class RequestHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Headers.Keys.Contains("X-Cancel-Request"))
            {
                context.Response.StatusCode = 500;
                return;
            }

            // await context.Response.WriteAsync("test");

            await _next.Invoke(context);

            // not calling

            context.Response.Headers.Add("X-Transfer-Success", "true");

            await context.Response.WriteAsync("test");

        }
    }
}
