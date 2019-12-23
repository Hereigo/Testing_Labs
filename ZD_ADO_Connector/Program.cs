using System;

namespace ZD_ADO_Connector
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {

                ZdProcessor zdProcessor = new ZdProcessor();
                zdProcessor.ApiClientForZendesk();
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
