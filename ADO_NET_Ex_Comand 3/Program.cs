using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ADO_NET_Ex_Comand_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String ConSt = "Data Source=tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com;Initial" +
                      " Catalog=TSOOPEX;User ID=admin;Password=Geirby1799";
            SqlConnection conection = new SqlConnection(ConSt);
            conection.Open();
            SqlCommand cmd = new SqlCommand("SELECT*FROM[TSOOPEX].[Person].[PersonPhone]", conection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetFieldValue<int>(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine("{0:D}",reader.GetDateTime(3));
            }
            conection.Close();

        }
    }
}
