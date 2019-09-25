using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Web.Mvc;
using MVC_AsyncController.Models;

namespace MVC_AsyncController.Controllers
{
	public class HomeController : Controller
	{
		private const int millisecondsDelay = 5000;

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Index()
		{
			return View();
		}

		// Approximately :
		// (5.00068) Get
		// (5.00064) Post
		// (5.00586) PostAsync

		// In case of double or triple click :
		// (6.59139) Rezult Get
		// (8.58931) Rezult Post
		// (5.00994) Rezult Post Async

		[HttpGet, AjaxOnly]
		public string ParallelIOBoundByGet(int num)
		{
			DateTime started = DateTime.Now;

			Task<int> rezult1 = Task.Run(() => LongTimeWork1(num));
			Task<int> rezult2 = Task.Run(() => LongTimeWork2(num));
			Task<int> rezult3 = Task.Run(() => LongTimeWork3(num));

			int summary = rezult1.Result + rezult2.Result + rezult3.Result;

			return $"({(DateTime.Now - started).TotalSeconds}) Rezult Get = {summary}";
		}

		[HttpPost, AjaxOnly]
		public string ParallelIOBoundByPost(int num)
		{
			DateTime started = DateTime.Now;

			Task<int> rezult1 = Task.Run(() => LongTimeWork1(num));
			Task<int> rezult2 = Task.Run(() => LongTimeWork2(num));
			Task<int> rezult3 = Task.Run(() => LongTimeWork3(num));

			int summary = rezult1.Result + rezult2.Result + rezult3.Result;

			return $"({(DateTime.Now - started).TotalSeconds}) Rezult Post = {summary}";
		}

		[HttpPost, AjaxOnly]
		public async Task<string> ParallelIOBoundByPostAsync(int num)
		{
			DateTime started = DateTime.Now;

			Task<int> rezultTask1 = LongTimeWork1Async(num);
			Task<int> rezultTask2 = LongTimeWork2Async(num);
			Task<int> rezultTask3 = LongTimeWork3Async(num);

			int rezult1 = await rezultTask1;
			int rezult2 = await rezultTask2;
			int rezult3 = await rezultTask3;

			int summary = rezult1 + rezult2 + rezult3;

			return $"({(DateTime.Now - started).TotalSeconds}) Rezult Post Async = {summary}";
		}

		public IActionResult Privacy()
		{
			return View();
		}

		private int LongTimeWork1(int num)
		{
			System.Threading.Thread.Sleep(millisecondsDelay);
			return num * 2;
		}

		private async Task<int> LongTimeWork1Async(int num)
		{
			await Task.Delay(millisecondsDelay);
			return num * 2;
		}

		private int LongTimeWork2(int num)
		{
			System.Threading.Thread.Sleep(millisecondsDelay);
			return num * 2;
		}

		private async Task<int> LongTimeWork2Async(int num)
		{
			await Task.Delay(millisecondsDelay);
			return num * 2;
		}

		private int LongTimeWork3(int num)
		{
			System.Threading.Thread.Sleep(millisecondsDelay);
			return num * 2;
		}

		private async Task<int> LongTimeWork3Async(int num)
		{
			await Task.Delay(millisecondsDelay);
			return num * 2;
		}
	}
}
