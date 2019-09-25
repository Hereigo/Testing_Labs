using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Core21_HttpClientFactory_HostedSvc
{
	public class HttpClientSvcAsBackground : BackgroundService
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly int _bgTaskDelay = 1000 * 10;
		private readonly IServiceScopeFactory _serviceScopeFactory;
		private readonly string _bearerToken = GIT_IGNORE.Variables.oAuth2Token;
		private readonly string _remoteServiceBaseUrl = GIT_IGNORE.Variables.httpApiClientBaseUrl;

		public HttpClientSvcAsBackground(IServiceScopeFactory serviceScopeFactory, IHttpClientFactory httpClientFactory)
		{
			_serviceScopeFactory = serviceScopeFactory;
			_httpClientFactory = httpClientFactory;
		}

		internal void GetRemoteServiceApiData()
		{
			string requestUri = _remoteServiceBaseUrl + "/api/v2/search.json?query=82385";

			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUri);

			request.Headers.Add("Accept", "application/json");
			request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

			HttpClient client = _httpClientFactory.CreateClient();

			Task<HttpResponseMessage> response = client.SendAsync(request);

			System.Console.WriteLine($"STATUS : {response.Result.StatusCode}");
			System.Console.WriteLine();
			System.Console.WriteLine($"HEADERS : {response.Result.Headers}");
			System.Console.WriteLine();
			System.Console.WriteLine($"CONTENT : {response.Result.Content.ReadAsStringAsync().Result}");
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			System.Console.WriteLine("ZendeskClientService background task is stopping.");

			while (!stoppingToken.IsCancellationRequested)
			{
				using (IServiceScope scope = _serviceScopeFactory.CreateScope())
				{
					GetRemoteServiceApiData();
				}
				await Task.Delay(_bgTaskDelay, stoppingToken);
			}
		}
	}
}
