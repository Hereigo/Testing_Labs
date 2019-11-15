using System;

namespace LookingForReferences
{
    static class Program
    {
        private static void Main()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logFile = desktop + "\\SEARCH_RESULT_" + DateTime.Now.ToString("yyMMdd_HHmmss") + ".log";
            string filesListToSearch = desktop + "\\SEARCH_WHAT.txt";
            string foldersToParseFile = desktop + "\\SEARCH_WHERE.txt";
            string fileExtensToParse = desktop + "\\SEARCH_IN_FILE_EXTEN.txt";

            try
            {
                Parser.ParseAndLog(foldersToParseFile, fileExtensToParse, filesListToSearch, logFile);
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
