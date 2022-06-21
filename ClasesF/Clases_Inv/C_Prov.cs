using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace ClasesF.Clases_Inv
{
    public class C_Prov
    {
        public C_Prov()
        {

        }
        private static readonly MySqlConnection Con = ConnectionDB.GetConnection();
        public int ID;
        string Nombre;
        string Email;
        string Agente;
        string Telefono
        public static List<C_Prov> CargarProv(string x)
        {
            Con.Open();
            
        }
    }
}
