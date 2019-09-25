using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace CallApi_TokenBasedAuth
{
	static class Program
	{
		static void Main()
		{
			try
			{
				string rezult = CallApi(GIT_IGNORE.Variables.apiRequestJsonPath, GIT_IGNORE.Variables.oAuth2Token);
				// string rez = CallApi(GIT_IGNORE.Variables.apiRequestJsonPath, GIT_IGNORE.Variables.apiRequestJsonToken); - work with CURL only :(

				System.Console.WriteLine(rezult);
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine($"ERROR : {ex.Message} !");
			}
			System.Console.WriteLine("\r\n Done.");
			System.Console.ReadKey();
		}

		static string GetToken(string url, string userName, string password)
		{
			var pairs = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>( "grant_type", "password" ),
				new KeyValuePair<string, string>( "username", userName ),
				new KeyValuePair<string, string> ( "Password", password )
			};

			FormUrlEncodedContent content = new FormUrlEncodedContent(pairs);

			ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

			using (var client = new HttpClient())
			{
				var response = client.PostAsync(url + "Token", content).Result;
				return response.Content.ReadAsStringAsync().Result;
			}
		}

		static string CallApi(string url, string token)
		{
			ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

			using (HttpClient client = new HttpClient())
			{
				if (!string.IsNullOrWhiteSpace(token))
				{
					// ignored in this case :
					// Token t = JsonConvert.DeserializeObject<Token>(token);

					client.DefaultRequestHeaders.Clear();
					client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token); // + t.access_token);
				}

				HttpResponseMessage response = client.GetAsync(url).Result;

				return response.Content.ReadAsStringAsync().Result;

				// { "tickets":[],"next_page":null,"previous_page":null,"count":0}

			}
		}
	}

	class Token
	{
		public string access_token { get; set; }
		public string token_type { get; set; }
		public int expires_in { get; set; }
		public string userName { get; set; }
		[JsonProperty(".issued")]
		public string issued { get; set; }
		[JsonProperty(".expires")]
		public string expires { get; set; }
	}
}
