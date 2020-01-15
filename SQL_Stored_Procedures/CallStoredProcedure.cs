using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Stored_Procedures
{
    internal static class CallStoredProcedure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "<Pending>")]
        public static void CallByName(string connStr, string procedureName)
        {
            Console.WriteLine($"Ready to call SP '{procedureName}'. Continue? ...");
            Console.ReadKey();

            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    Console.WriteLine("Connection opened...");

                    SqlCommand cmd = new SqlCommand(procedureName, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Console.WriteLine(Environment.NewLine + "Retrieving data from database..." + Environment.NewLine);
                        Console.WriteLine("Retrieved records:");

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                int ProductID = dr.GetInt32(0);
                                string ProductName = dr.GetString(1);
                                string ProductDescription = dr.GetString(2);

                                Console.WriteLine($"{ProductID.ToString()} \t {ProductName} \t {ProductDescription}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
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
