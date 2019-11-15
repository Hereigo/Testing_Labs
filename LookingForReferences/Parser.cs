using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LookingForReferences
{
    internal static class Parser
    {
        public static void ParseAndLog(string foldersToParseFile, string fileExtensToParse, string filesListToSearch, string logFileName)
        {
            // Create Collections of String to proccess :

            string[] filesToSearch = TextFileToCollection(filesListToSearch);
            string[] foldersToParse = TextFileToCollection(foldersToParseFile);
            string[] fileTypesToParse = TextFileToCollection(fileExtensToParse);

            // Get list of all files with the predefined extension in the selected folders :

            List<string> existedFilesToParse = new List<string>();

            foreach (string folder in foldersToParse)
            {
                IEnumerable<string> currentDirFiles = Directory
                    .GetFiles(folder, "*.*", SearchOption.AllDirectories)
                    .Where(s => fileTypesToParse.Contains(Path.GetExtension(s).ToLower()));

                existedFilesToParse.AddRange(currentDirFiles);
            }

            // PARSING :

            List<string> result = new List<string>();

            string previousDir = "";
            string previousFileName = "";

            foreach (string fileToParse in existedFilesToParse)
            {
                // Open every file with predefined extension that is exists :

                using (StreamReader fileStreamToParse = new StreamReader(fileToParse))
                {
                    string line;
                    int lineNumber = 0;
                    while ((line = fileStreamToParse.ReadLine()) != null)
                    {
                        lineNumber++;
                        foreach (string searchingFile in filesToSearch)
                        {
                            // Compare every line of file with every search-pattern :

                            if (line.ToLower().Contains(searchingFile))
                            {
                                string currentDir = Path.GetDirectoryName(fileToParse);
                                if (currentDir != previousDir)
                                {
                                    result.Add($"\r\n{currentDir.ToUpper()}\r\n");
                                    previousDir = currentDir;
                                }

                                string currentFileName = Path.GetFileName(fileToParse);
                                if (currentFileName != previousFileName)
                                {
                                    result.Add($"{currentFileName.ToUpper()} :");
                                    previousFileName = currentFileName;
                                }
                                result.Add(lineNumber + " : " + line);
                                break;
                            }
                        }
                    }
                }
            }
            // SAVE REZULT :
            File.AppendAllLines(logFileName, result);
        }

        private static string[] TextFileToCollection(string textFile)
        {
            List<string> stringsCollection = new List<string>();

            using (StreamReader fileToRead = new StreamReader(textFile))
            {
                string line;

                while ((line = fileToRead.ReadLine()) != null)
                {
                    stringsCollection.Add(line.Trim());
                }
            }
            return stringsCollection.ToArray();
        }
    }
}
