using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CODE_SNIPPETS
{
	internal class ASYNC_vs_SYNCRO
	{
		private const string downloadUrl = "https://dou.ua/lenta/columns/hiring-programmers/#1634100";
		private const string downloadUrl2 = "https://stackoverflow.com/questions/30225476/task-run-with-parameters/30225551";
		private const string downloadUrl3 = "https://dou.ua/lenta/articles/relocation-to-luxembourg/";

		internal void Start()
		{
			Stopwatch stopwatch = Stopwatch.StartNew();

			Task<string> AsyncRezult = GetAllDataAsync();
			Task<string> SyncroRezult = GetAllDataSyncro();

			// MUST WAIT FOR ASYNC REZULT !!!
			Console.WriteLine("\r\n ASYNC REZULT = " + AsyncRezult.Result);

			stopwatch.Stop();
			Console.WriteLine("\r\n FULL TIME : " + stopwatch.ElapsedMilliseconds);
		}

		private async Task<string> GetAllDataAsync() // milliseconds 5270, 4949, 4329, 5161, 4568, 4653 = 5053, 4354, 4913, 4341
		{
			Stopwatch watch = Stopwatch.StartNew();

			string result;

			string aaa = await Task.Run(GetLongTimeData1).ConfigureAwait(false);
			string bbb = await Task.Run(GetLongTimeData2).ConfigureAwait(false);
			string ccc = await Task.Run(GetLongTimeData3).ConfigureAwait(false);
			string aaa2 = await Task.Run(GetLongTimeData1).ConfigureAwait(false);
			string bbb2 = await Task.Run(GetLongTimeData2).ConfigureAwait(false);
			string ccc2 = await Task.Run(GetLongTimeData3).ConfigureAwait(false);

			result = aaa + bbb + ccc + aaa2 + bbb2 + ccc2;

			watch.Stop();
			Console.WriteLine($"\r\n\r\n ASYNC TIME : {watch.ElapsedMilliseconds}");
			return result;
		}

		private async Task<string> GetAllDataSyncro() //  milliseconds 4375, 4770, 4041, 7192, 4311, 4695 = 4538, 4727, 4796, 4136
		{
			Stopwatch watch = Stopwatch.StartNew();

			string result;

			string aaa = GetLongTimeData1();
			string bbb = GetLongTimeData2();
			string ccc = GetLongTimeData3();
			string aaa2 = GetLongTimeData1();
			string bbb2 = GetLongTimeData2();
			string ccc2 = GetLongTimeData3();

			result = aaa + bbb + ccc + aaa2 + bbb2 + ccc2;

			watch.Stop();
			Console.WriteLine($"\r\n SYNCRO TIME : {watch.ElapsedMilliseconds}");
			return result;
		}

		private string GetLongTimeData1()
		{
			HttpClient _httpClient = new HttpClient();
			Task<HttpResponseMessage> responseTask = _httpClient.GetAsync(downloadUrl);
			Task<string> stringTask = responseTask.Result.Content.ReadAsStringAsync();

			int count = Regex.Matches(stringTask.Result, ".net", RegexOptions.IgnoreCase).Count * 1000;

			return count.ToString();
		}

		private string GetLongTimeData2()
		{
			HttpClient _httpClient = new HttpClient();
			Task<HttpResponseMessage> responseTask = _httpClient.GetAsync(downloadUrl2);
			Task<string> stringTask = responseTask.Result.Content.ReadAsStringAsync();

			int count = Regex.Matches(stringTask.Result, ".net", RegexOptions.IgnoreCase).Count * 1000;

			return count.ToString();
		}

		private string GetLongTimeData3()
		{
			HttpClient _httpClient = new HttpClient();
			Task<HttpResponseMessage> responseTask = _httpClient.GetAsync(downloadUrl3);
			Task<string> stringTask = responseTask.Result.Content.ReadAsStringAsync();

			int count = Regex.Matches(stringTask.Result, ".net", RegexOptions.IgnoreCase).Count * 1000;

			return count.ToString();
		}
	}
}
