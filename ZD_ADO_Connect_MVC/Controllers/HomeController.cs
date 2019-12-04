using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZdAdoConnectorMvc.Models;

namespace ZdAdoConnectorMvc.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        public IActionResult Index() => View();

        public IActionResult Privacy() => View();
    }
}
