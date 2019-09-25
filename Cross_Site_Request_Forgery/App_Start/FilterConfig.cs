using System.Web;
using System.Web.Mvc;

namespace Cross_Site_Request_Forgery
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
