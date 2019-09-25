using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware_Simple.Middleware
{
    public class AuthorizationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Headers.Keys.Contains("X-Not-Authorized"))
            {
                context.Response.StatusCode = 401;
                return;
            }

            await _next.Invoke(context);
        }
    }
}
