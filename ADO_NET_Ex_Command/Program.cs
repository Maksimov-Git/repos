using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using System.Configuration;
using System.Collections.Specialized;

namespace ADO_NET_Ex_Command
{
    class Program
    {
        static void Main(string[] args)
        {
          ConnectionStringSettingsCollection sett = ConfigurationManager.ConnectionStrings;
         string  conStr = sett[2].ConnectionString;
            //   получение строки подключения из файла конфигурации

            SqlConnection Connection = new SqlConnection(conStr);
            // создание нового подключения 


            SqlCommand sql = new SqlCommand();

            sql.Connection = Connection;
            sql.CommandText = "SELECT TOP (1000) * FROM[TSOOPEX].[Person].[Address]";


            sql = Connection.CreateCommand();
            sql.CommandText = "SELECT TOP (1000) * FROM[TSOOPEX].[Person].[Address]";

            sql = new SqlCommand("SELECT TOP (1000) * FROM[TSOOPEX].[Person].[Address]", Connection);



        }
    }
}
