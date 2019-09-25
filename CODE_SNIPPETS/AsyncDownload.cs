using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CODE_SNIPPETS
{
	public class AsyncDownload
	{
		private const string downloadUrl = "https://dou.ua/lenta/columns/hiring-programmers/#1634100";
		private const string downloadUrl2 = "https://stackoverflow.com/questions/30225476/task-run-with-parameters/30225551";
		private const string downloadUrl3 = "https://dou.ua/lenta/articles/relocation-to-luxembourg/";

		private readonly HttpClient _httpClient = new HttpClient();

		public void A_Start()
		{
			AsyncWithContinue(); // Blockign Thread.
			AsyncWithAwait();
			SomeBackgroundWork();
		}

		private async void AsyncWithAwait()
		{
			int result = await Task.Run(() => DownloadAndCountAsync(downloadUrl));
			Console.WriteLine(result);
		}

		private async void AsyncWithContinue()
		{
			await DownloadAndCountAsync(downloadUrl2)
				.ContinueWith(result => Console.WriteLine(result.Result))
				.ConfigureAwait(false);
		}

		private Task<int> DownloadAndCountAsync(string downloadUrl)
		{
			System.Threading.Thread.Sleep(2000);

			Task<HttpResponseMessage> responseTask = _httpClient.GetAsync(downloadUrl);
			Task<string> stringTask = responseTask.Result.Content.ReadAsStringAsync();

			int count = Regex.Matches(stringTask.Result, ".net", RegexOptions.IgnoreCase).Count;
			return Task.FromResult(count);
		}

		private void SomeBackgroundWork()
		{
			for (int i = 0; i < 25; i++)
			{
				Console.Write('.');
				System.Threading.Thread.Sleep(300);
			}
		}
	}
}
