using Payments_Net462.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Payments_Net462
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			//Database.SetInitializer(new PaymentsDbInitializer());

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
