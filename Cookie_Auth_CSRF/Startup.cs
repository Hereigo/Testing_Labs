using Cookie_Auth_CSRF.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cookie_Auth_CSRF
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();
			app.UseAuthentication(); // ACTIVATE AUTHENTIFICATION

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}

		// This method gets called by the runtime to get your services from the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// User Consent - for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;

				options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.Lax; // or None, or Strict
			});

			services.AddDbContext<DatabaseContext>(options =>
					options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

			// CONFIG AUTHENTIFICATION FOR COOKIE :

			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(options =>
				{
					options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
					options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
				});

			services.AddMvc();
		}
	}
}
