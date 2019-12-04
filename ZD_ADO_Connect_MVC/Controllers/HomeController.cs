using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZdAdoConnectorMvc.Models;
using ZdAdoConnectorMvc.Providers;

namespace ZdAdoConnectorMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdoProvider _adoProvider;

        public HomeController(AdoProvider adoProvider) => _adoProvider = adoProvider;

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        public IActionResult GetWorkItems()
        {
            List<AdoWorkItemModel> rez = _adoProvider.GetWorkItems(new int[] { 1 });

            var test = rez.ToArray()[0];

            return View(test);
        }

        public IActionResult Index()
        {
            List<AdoWorkItemModel> rez = _adoProvider.GetWorkItems(new int[] { 1 });

            return View(rez);
        }

        public IActionResult Privacy() => View();
    }
}
