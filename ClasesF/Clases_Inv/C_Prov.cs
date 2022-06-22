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
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Agente { get; set; }
        public static List<C_Prov> CargarProv(string x)
        {
            List<C_Prov> lista = new List<C_Prov>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_PS", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomb", x);
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read()) {
                lista.Add(new C_Prov() {
                    ID = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Email = lector.GetString(3),
                    Agente = lector.GetString(4),
                    Telefono = lector.GetString(2)
                });
            }
            Con.Close();
            return lista;
        }
        public List<C_Prov> InsertProv()
        {
            List<C_Prov> lista = new List<C_Prov>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_PI", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreS", Nombre);
            cmd.Parameters.AddWithValue("@TelefS", Telefono);
            cmd.Parameters.AddWithValue("@EmailS", Email);
            cmd.Parameters.AddWithValue("@AgenteS", Agente);
            MySqlDataReader lector = cmd.ExecuteReader();
            string ID = null;
            if (lector.Read())
               ID = lector.GetInt32(0).ToString();
            else
                return null;
            Con.Close();
            return CargarProv(ID);
        }
        public List<C_Prov> UpdateProv()
        {
            List<C_Prov> lista = new List<C_Prov>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_PU", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@nombreS", Nombre);
            cmd.Parameters.AddWithValue("@TelefS", Telefono);
            cmd.Parameters.AddWithValue("@EmailS", Email);
            cmd.Parameters.AddWithValue("@AgenteS", Agente);
            cmd.ExecuteNonQuery();
            Con.Close();
            return CargarProv(ID.ToString());

        }
        }
}
