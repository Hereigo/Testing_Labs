using System;
using System.IO;
using System.Net;
using System.Text;

namespace Trio_Auth
{
	internal static class Program
	{
		internal static void Main()
		{
			string formUrl = GIT_IGNORE.Variables.TrioLoginPage;
			string pathForPost = GIT_IGNORE.Variables.TrioPostPath;


			string cookieHeader = RequestCookieHeader(formUrl);

			Console.WriteLine(cookieHeader);

			RequestAuthorizing(cookieHeader, pathForPost);

			Console.WriteLine("\r\n Done.");
			Console.ReadKey();
		}

		private static void RequestAuthorizing(string cookieHeader, string pathForPost)
		{
			try
			{
				WebRequest req = WebRequest.Create(pathForPost);
				req.ContentType = "application/x-www-form-urlencoded";
				req.Method = "POST";

				string formParams = string.Format(
					"ctl00$CPH1$Login1$UserName={0}&ctl00$CPH1$Login1$Password={1}&ctl00$CPH1$Login1$LoginButton={2}",
					GIT_IGNORE.Variables.TrioLoginUser, GIT_IGNORE.Variables.TrioLoginPassw, GIT_IGNORE.Variables.TrioLoginBtn);

				byte[] bytes = Encoding.ASCII.GetBytes(formParams);

				req.ContentLength = bytes.Length;

				using (Stream stream = req.GetRequestStream())
				{
					stream.Write(bytes, 0, bytes.Length);
				}

				// Add Asp.Net Session cookies :
				foreach (string item in cookieHeader.Split(';'))
				{
					if (item.StartsWith("ASP.NET_SessionId"))
					{
						string[] pair = item.Split('=');

						bool cookieTest = req.TryAddCookie(new Cookie(pair[0], pair[1]));
					}
				}

				WebResponse resp = req.GetResponse();

				Stream responseStream = resp.GetResponseStream();

				StreamReader sr = new StreamReader(responseStream, Encoding.UTF8);

				string rez = sr.ReadToEnd();

				File.WriteAllText("TEST.HTML", rez);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private static string RequestCookieHeader(string formUrl)
		{
			WebRequest req = WebRequest.Create(formUrl);

			req.ContentType = "application/x-www-form-urlencoded";

			req.Method = "GET";

			WebResponse resp = req.GetResponse();

			return resp.Headers["Set-cookie"];
		}

		private static bool TryAddCookie(this WebRequest webRequest, Cookie cookie)
		{
			if (!(webRequest is HttpWebRequest httpRequest))
			{
				return false;
			}

			(httpRequest.CookieContainer ?? (httpRequest.CookieContainer = new CookieContainer()))
				.Add(new Uri(GIT_IGNORE.Variables.TrioRootPath), cookie);

			return true;
		}
	}
}
