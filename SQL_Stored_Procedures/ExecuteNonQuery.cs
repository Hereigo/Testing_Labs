using System;
using System.Data.SqlClient;
using System.IO;

namespace SQL_Stored_Procedures
{
    internal static class ExecuteNonQuery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "<Pending>")]
        public static void CommandFromFile(string connStr, string db, string sqlCommandFile)
        {
            Console.WriteLine($"Ready to call {sqlCommandFile} for'{db}'  Database. Continue? ...");
            Console.ReadKey();

            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    Console.WriteLine("Connection opened...");

                    using (SqlCommand command = new SqlCommand(File.ReadAllText(sqlCommandFile), connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("All done.");
        }
    }
}
