using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleApiClient_472
{
	class Program
	{
		static void Main(string[] args)
		{
			RunAsync().GetAwaiter().GetResult();
		}

		static readonly HttpClient httpClient = new HttpClient();

		static async Task RunAsync()
		{
			httpClient.BaseAddress = new System.Uri(GIT_IGNORE.Variables.httpApiClientBaseUrl);
			httpClient.DefaultRequestHeaders.Accept.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GIT_IGNORE.Variables.oAuth2Token);

			try
			{
				string rezult = await GetDataAsync(GIT_IGNORE.Variables.httpApiClientReqPath);

				System.Console.WriteLine(rezult);
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine($"ERROR: {ex.Message}");
			}
			System.Console.WriteLine("\r\n Done.");
			System.Console.ReadKey();
		}

		static async Task<string> GetDataAsync(string httpApiClientReqPath)
		{
			string rezult;
			HttpResponseMessage responseMessage = await httpClient.GetAsync(httpApiClientReqPath);

			if (responseMessage.IsSuccessStatusCode)
			{
				rezult = await responseMessage.Content.ReadAsStringAsync();
			}
			else
			{
				rezult = $"Response StatusCode is = {responseMessage.StatusCode} = !";
			}
			return rezult;

			// { "tickets":[],"next_page":null,"previous_page":null,"count":0}

		}
	}
}
