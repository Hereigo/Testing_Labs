using System;

namespace SQL_Stored_Procedures
{
    internal static class Program
    {
        private static void Main()
        {
            const bool dropDatabaseBefore = true;

            const string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;";

            Initialisation.CreateAndFillDb(dropDatabaseBefore, connStr);

            Console.WriteLine("Done.");
        }
    }
}