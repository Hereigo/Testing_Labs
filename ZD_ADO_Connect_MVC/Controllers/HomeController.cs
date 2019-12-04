using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZdAdoConnectorMvc.Models;
using ZdAdoConnectorMvc.Services;

namespace ZdAdoConnectorMvc.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        public IActionResult Index()
        {
            Task<string> adoResponse = AdoHttpClient.GetProjects();

            AdoProjectsResponse TETS2 = Converter.FromJson(adoResponse.Result);

            return View();
        }

        public IActionResult Privacy() => View();
    }
}
