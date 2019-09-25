using System.Web.Mvc;
using Cross_Site_Request_Forgery.Models;

namespace Cross_Site_Request_Forgery.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(Customer customer)
		{
			return View(customer);
		}
	}
}