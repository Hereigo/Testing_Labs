using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookingForReferences
{
    static class Parser
    {
        public static void ParseAndLog(string[] foldersToParse, string[] fileTypes, string filesListToSearch, string logFileName)
        {
            // FILES TO LOOK FOR :

            List<string> filesCollectToSearch = new List<string>();

            StreamReader fileToRead = null;
            using (fileToRead = new StreamReader(filesListToSearch))
            {
                string line;

                while ((line = fileToRead.ReadLine()) != null)
                {
                    filesCollectToSearch.Add(line.Trim());
                }
            }

            // FILES WHERE TO LOOK FOR :

            List<string> filesCollectToParse = new List<string>();

            foreach (string folder in foldersToParse)
            {
                // Get List of available files with defined extensions :
                IEnumerable<string> currentDirFiles = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories)
                    .Where(s => fileTypes.Contains(Path.GetExtension(s).ToLower()));

                filesCollectToParse.AddRange(currentDirFiles);
            }

            // PARSING :

            StreamReader fileStreamToParse = null;

            foreach (string fileToParse in filesCollectToParse)
            {
                using (fileStreamToParse = new StreamReader(fileToParse))
                {
                    string line;

                    while ((line = fileStreamToParse.ReadLine()) != null)
                    {
                        // TODO :
                        // Check IF LINE CONTAINS file name !!!

                        // Write FILE NAME
                        // may be line number...
                        // 
                        File.AppendAllText(logFileName, line);
                    }
                }
            }
        }
    }
}
