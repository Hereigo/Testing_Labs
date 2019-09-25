using System;
using System.Text.RegularExpressions;

namespace CODE_SNIPPETS
{
	public static class TextAndRegex
	{
		public static string REMOVE_NON_LETTERS(string inputString)
		{
			return Regex.Replace(inputString, "[^A-Za-z ]", ""); // SPACES allowed!
		}

		public static bool IS_VALID_GUID(string Guid)
		{
			const string GUID_PATTERN = "^[{(]?[0-9A-F]{8}[-]?([0-9A-F]{4}[-]?){3}[0-9A-F]{12}[)}]?$";

			return Regex.IsMatch(Guid, GUID_PATTERN, RegexOptions.IgnoreCase | RegexOptions.Singleline);
		}

		public static string GetFileRefOrEmpty(string input)
		{
			const string urlPattern = @"((http(s)?(\:\/\/))+(www\.)?([\w\-\.\/])*(\.[a-zA-Z]{2,3}\/?))[^\s\b\n|]*[^.,;:)\?\!\@\^\$ -]";
			//            "((http(s)?(\\:\\/\\/))+(www\\.)?([\\w\\-\\.\\/])*(\\.[a-zA-Z]{2,3}\\/?))[^\\s\\b\\n|]*[^.,;:)\\n\"\\?\\!\\@\\^\\$ -]";

			return Regex.Match(input, urlPattern)?.Value ?? string.Empty;
		}

		public static void GuidShortenAsBase64Modif()
		{
			Guid _guid = Guid.NewGuid();

			Console.WriteLine($"Guid.Length = {_guid.ToString().Length}");

			string _guidModif = Convert.ToBase64String(_guid.ToByteArray()).Replace("/", "-").Replace("+", "_").Replace("=", "");

			Console.WriteLine($"Modif.Length = {_guidModif.Length}");
		}
	}
}
