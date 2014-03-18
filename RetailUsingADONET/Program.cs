using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

namespace RetailUsingADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            var strConn = @"Data Source=.\sqlexpress2008;Initial Catalog=Retail;Integrated Security=True";

            using (var conn = new SqlConnection(strConn))
            {
                conn.Open();

                var sql = @"SELECT NamaSupplier, Jalan 
                            FROM Supplier";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var dtr = cmd.ExecuteReader())
                    {
                        var noUrut = 1;

                        while (dtr.Read())
                        {
                            Console.WriteLine("{0}. {1}, {2}", noUrut, dtr["NamaSupplier"], dtr.GetString(1));

                            noUrut++;
                        }
                    }
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
