using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO_NET_Ex_Command_1
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            String ConSt = "Data Source=tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com;Initial" +
            " Catalog=TSOOPEX;User ID=admin;Password=Geirby1799";
            SqlConnection conection = new SqlConnection(ConSt);

            conection.Open();
            SqlCommand Cmd = new SqlCommand("SELECT [PostalCode] FROM [TSOOPEX].[Person].[Address] WHERE [AddressID] = 1 ", conection);

            string PostCod = (string)Cmd.ExecuteScalar();
            Console.WriteLine(PostCod);

            SqlCommand Cmd1 = conection.CreateCommand();
            Cmd1.CommandText = "INSERT INTO[Person].[PersonPhone] ([BusinessEntityID],[PhoneNumber],[PhoneNumberTypeID],[ModifiedDate])" +
                "VALUES(8,185-555-0186,1,2009-01-09) ";
            int res = Cmd1.ExecuteNonQuery();
            Console.WriteLine(res);

            SqlCommand Cmd3 = conection.CreateCommand();
            Cmd3.CommandText = "DELETE [TSOOPEX].[Person].[PersonPhone] WHERE [BusinessEntityID] = 8 ";
            res = Cmd3.ExecuteNonQuery();
            Console.WriteLine(res);


            conection.Close();

            Console.ReadKey();

        }
    }
}
