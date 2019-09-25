using Microsoft.AspNetCore.Mvc;
using MVC_AsyncController.Models;

namespace MVC_AsyncController.Controllers
{
	public class PartAsyncController : Controller
	{
		public IActionResult Index()
		{
			EmployeeViewModel model = new EmployeeViewModel
			{
				Id = 1,
				Firstname = "James",
				Surname = "Bond"
			};
			return View(model);
		}

		public IActionResult PartialAddress()
		{
			System.Threading.Thread.Sleep(3000);

			AddressViewModel Address = new AddressViewModel
			{
				Line1 = "Secret Location",
				Line2 = "London",
				Line3 = "UK"
			};

			return PartialView("_Address", Address);
		}
	}
}