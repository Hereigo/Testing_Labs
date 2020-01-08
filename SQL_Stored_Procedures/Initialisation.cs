using System;
using System.Data.SqlClient;

namespace SQL_Stored_Procedures
{
    internal static class Initialisation
    {
        private const string myDbName = "myDb-2020-0108";
        private const string myFirstTable = "TestModelTable";

        public static void CreateAndFillDb(bool dbShouldBeDropped, string connStr)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    Console.WriteLine("Connection opened...");

                    string sql;

                    if (dbShouldBeDropped)
                    {
                        sql = $"DROP DATABASE IF EXISTS [{myDbName}]; CREATE DATABASE [{myDbName}]";

                        Console.Write($"Dropping and creating database '{myDbName}' ... ");

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            Console.WriteLine($"Database '{myDbName}' RE-Created.");
                        }
                    }

                    sql = "USE [" + myDbName + "]; "
                    + "CREATE TABLE " + myFirstTable + " ( "
                    + " Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, "
                    + " Name NVARCHAR(50), "
                    + " Description NVARCHAR(50) "
                    + "); "
                    + "INSERT INTO " + myFirstTable + " (Name, Description) VALUES "
                    + "(N'Alex', N'First db record.'), "
                    + "(N'Felix', N'Another database row...'), "
                    + "(N'Jessica', N'Some another info...'); ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Done.");
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
