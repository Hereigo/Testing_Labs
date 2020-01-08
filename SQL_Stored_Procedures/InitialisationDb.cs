using System;
using System.Data.SqlClient;

namespace SQL_Stored_Procedures
{
    internal static class InitialisationDb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "<Pending>")]
        public static void DropAndRecreate(string connStr, string db)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    Console.WriteLine("Connection opened...");

                    string sqlCmd = $"DROP DATABASE IF EXISTS [{db}]; CREATE DATABASE [{db}]";

                    Console.Write($"Prepairing to Drop database '{db}' and re-create it. Continue? ... ");
                    Console.ReadKey();

                    using (SqlCommand command = new SqlCommand(sqlCmd, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Database '{db}' RE-Created.");
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(true);
        }
    }
}
