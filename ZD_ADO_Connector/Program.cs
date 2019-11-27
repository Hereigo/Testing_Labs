using System;

namespace ZD_ADO_Connector
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                AdoProcessor adoProcessor = new AdoProcessor();
                // adoProcessor.CreateIssueUsingClientLib();
                // adoProcessor.UpdateWorkItemAsyncUsingClientLib(0);

                ZdProcessor zdProcessor = new ZdProcessor();
                // zdProcessor.ZendeskApiClient();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\r\n Finished.");
            Console.ReadKey();
        }
    }
}
