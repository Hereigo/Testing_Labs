using System;
using System.IO;

namespace LookingForReferences
{
    static class Program
    {
        private static void Main()
        {
            string logFileName = "REFS_LOG_" + DateTime.Now.ToString("yyMMdd_HHmmss") + ".log";

            string filesListToSearch = "filesListToSearch.txt";

            string[] foldersToParse = {
                @"C:\Users\user\Downloads",
                @"C:\Users\user\Documents"
            };

            string[] fileTypesToParse = { ".asp", ".asp_bk", ".aspx", ".js", ".vb", ".htm", ".html", ".ini", ".config", ".ascx", ".asax", ".xml" };

            try
            {
                Parser.ParseAndLog(foldersToParse, fileTypesToParse, filesListToSearch, logFileName);
            }
            catch (UnauthorizedAccessException authEx)
            {
                Console.WriteLine("NO ACCESS TO :");
                Console.WriteLine(authEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : ");
                Console.WriteLine(ex);
            }
            Console.WriteLine("FINISHED.");
            Console.ReadKey();
        }
    }
}
