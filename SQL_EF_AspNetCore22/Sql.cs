using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SQL_EF_AspNetCore22
{
    public static class Sql
    {
        internal static IQueryable<Employee> CallspGetAllEmployees()
        {

            EmployeeContext context = new EmployeeContext();

            return context.Employees.FromSql("spGetAllEmployees"); //.ToList();

            //using (var context = new EmployeeContext())
            //{
            //    var clientIdParameter = new SqlParameter("@ClientId", 4);

            //    var result = context.Database
            //        .SqlQuery<ResultForCampaign>("GetResultsForCampaign @ClientId", clientIdParameter)
            //        .ToList();
            //}

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connStr))
            //    {
            //        connection.Open();
            //        Console.WriteLine("Connection opened...");

            //        SqlCommand cmd = new SqlCommand(procedureName, connection)
            //        {
            //            CommandType = CommandType.StoredProcedure
            //        };

            //        using (SqlDataReader dr = cmd.ExecuteReader())
            //        {
            //            Console.WriteLine(Environment.NewLine + "Retrieving data from database..." + Environment.NewLine);
            //            Console.WriteLine("Retrieved records:");

            //            if (dr.HasRows)
            //            {
            //                while (dr.Read())
            //                {
            //                    int ProductID = dr.GetInt32(0);
            //                    string ProductName = dr.GetString(1);
            //                    string ProductDescription = dr.GetString(2);

            //                    Console.WriteLine($"{ProductID.ToString()} \t {ProductName} \t {ProductDescription}");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("No data found.");
            //            }
            //        }
            //    }
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
