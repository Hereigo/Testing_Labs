using System;

namespace SQL_Stored_Procedures
{
    internal static class Program
    {
        private static void Main()
        {
            const string db = "myDb-2020-0108";

            const string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;";

            // !!! DROP & RE-CREATE DB !!! :
            InitialisationDb.DropAndRecreate(connStr, db);

            ExecuteNonQuery.CommandFromFile(connStr, db, "cmInitTableData.sql");

            ExecuteNonQuery.CommandFromFile(connStr, db, "spGetProductDesc.sql");

            CallStoredProcedure.CallByName(connStr, "GetProductDesc");

            Console.WriteLine("Done.");
        }
    }
}