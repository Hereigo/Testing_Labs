using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core21_ConsoleWebHost
{
	internal class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			// Has already 5 providers: MemoryConfig, JsonConfig, EnvVars..., etc.
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// has 63 services already.
			services.AddMvc();

			//services.AddTransient<ICounterService, CounterService>();
			services.AddScoped<ICounterService, CounterService>();
			// services.AddSingleton<CounterServiceFactory>(); // use first CounterService - Error if .AddScoped<ICounterService...
			services.AddScoped<CounterServiceFactory>(); // use previous CounterService.

			services.AddSwaggerGen(c => c.SwaggerDoc("v1",
				new Swashbuckle.AspNetCore.Swagger.Info { Title = "My Test API", Version = "v1" }));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Test API v1");
				// c.RoutePrefix = string.Empty; = Set Swagger as a start page
			});

			app.UseStaticFiles();

			// JUST WRITE THE NEW RANDOM COUNTER :
			// app.Run(async context =>
			// {
			// 	ICounterService timeSvc = context.RequestServices.GetService<ICounterService>();
			// 	await context.Response.WriteAsync(timeSvc.GetVal.ToString()).ConfigureAwait(false);
			// });

			// ANOTHER WAY (MIDDLEWARE):
			app.UseMiddleware<ChangeStatusMiddleware>();

			app.MapWhen(context => context.Request.Query.ContainsKey("test"), TestKeyHandler);

			// COUNTER temporary disabled.
			app.UseMiddleware<CounterMiddleware>();

			// Do not started if AFTER - app.UseMiddleware()
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}

		private static void TestKeyHandler(IApplicationBuilder app)
		{
			app.Run(async context =>
			{
				string testKey = context.Request.Query["test"].ToString();

				await context.Response.WriteAsync($"<h2>TEST HAS KEY = {testKey}</h2>").ConfigureAwait(false);
			});
		}
	}
}