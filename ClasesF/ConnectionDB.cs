using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ClasesF
{
    public class ConnectionDB
    {
      public static MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            return con;
        }
    }
}
