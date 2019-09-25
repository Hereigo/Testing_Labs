using Core_MVC_DataTables.Contracts;
using Core_MVC_DataTables.Models;
using JqueryDataTables.ServerSide.AspNetCoreWeb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Core_MVC_DataTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPseudoDbService _pseudoDbService;

        public HomeController(IPseudoDbService pseudoDbService)
        {
            _pseudoDbService = pseudoDbService;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            //try
            //{
            //    UserModel[] users = _pseudoDbService.Get500Users();

            return View(); // users);
            //}
            //catch (Exception e)
            //{
            //    return new JsonResult(new { error = "Internal Server Error", message = e.Message });
            //}
        }

        public IActionResult JsonModel()
        {
            try
            {
                UserModel[] users = _pseudoDbService.Get500Users();

                return Json(users);
            }
            catch (Exception e)
            {
                return new JsonResult(new { error = "Internal Server Error", message = e.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> ServerSideModel([FromBody]DTParameters param)
        {
            try
            {
                UserViewModel[] users = await _pseudoDbService.GetUsersAsync(param);

                return new JsonResult(new DTResult<UserViewModel>
                {
                    draw = param.Draw,
                    data = users,
                    recordsFiltered = users.Length,
                    recordsTotal = users.Length
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { error = "Internal Server Error", message = e.Message });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
