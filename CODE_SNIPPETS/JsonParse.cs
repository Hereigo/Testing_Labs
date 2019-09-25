using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CODE_SNIPPETS
{
	public static class JsonParse
	{
		public static void Test()
		{
			try
			{
				// {
				// 	"comments": [{
				// 			"id": 123456789012,
				// 			"type": "Some type",
				// 			"body": "... long text with URL-s ... ",
				//			"someTag": "..."
				//		}, {
				//			"id": 123456789012,
				//			"type": "Another type",
				//			"body": "... another long text with URL-s ...
				string jsonFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/COMMENTS.json";

				if (!File.Exists(jsonFile))
				{
					Console.WriteLine("NOT FOUND! - " + jsonFile);
				}
				else
				{
					string json = File.ReadAllText(jsonFile);

					JArray comments = (JArray)JObject.Parse(json)["comments"];

					if (comments != null)
					{
						foreach (JToken oneComment in comments)
						{
							string fileReference = TextAndRegex.GetFileRefOrEmpty(oneComment["body"].ToString());

							if (!string.IsNullOrEmpty(fileReference))
							{
								Console.WriteLine($"{oneComment["id"]} - {fileReference}");
							}
						}
					}

					Console.WriteLine("Done.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("ERROR : " + ex.Message);
			}
		}
	}
}
