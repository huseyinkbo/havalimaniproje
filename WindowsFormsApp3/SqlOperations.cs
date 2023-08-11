using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
   public class SqlOperations
    {
     
           public static SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-50EGEF8\HUSEYIN2244;Initial Catalog=Havaalanicsharpproje;Integrated Security=True");

             public static void Kontrolbaglanti(SqlConnection tempConnection)
            {
                if (tempConnection.State == ConnectionState.Closed)
                {
                    tempConnection.Open();
                }
                else
                {

                }
            }

     
    }
}

