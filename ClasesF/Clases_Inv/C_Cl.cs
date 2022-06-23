using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace ClasesF.Clases_Inv
{
    public class C_Cl
    {
        public C_Cl()
        {

        }
        private static readonly MySqlConnection Con = ConnectionDB.GetConnection();
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string RNC { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }
        public string Email { get; set; }
        public static List<C_Cl> CargarCl(string x)
        {
            List<C_Cl> lista = new List<C_Cl>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_ClS", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomb", x);
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new C_Cl()
                {
                    ID = lector.GetInt32(0),
                    Cedula = lector.GetString(1),
                    RNC = lector.GetString(2),
                    Nombre = lector.GetString(3),
                    Apellido = lector.GetString(4),
                    Telefono = lector.GetString(5),
                    Ubicacion = lector.GetString(6),
                    Email = lector.GetString(7)
                });
            }
            Con.Close();
            return lista;
        }
        public List<C_Cl> InsertCl()
        {
            List<C_Cl> lista = new List<C_Cl>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_ClI", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", Cedula);
            cmd.Parameters.AddWithValue("@RNC", RNC);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@Email", Email);
            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                ID = lector.GetInt32(0);
            }
            Con.Close();
            return CargarCl(ID.ToString());
        }
        public List<C_Cl> UpdateCl()
        {
            List<C_Cl> lista = new List<C_Cl>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_ClU", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Cedula", Cedula);
            cmd.Parameters.AddWithValue("@RNC", RNC);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.ExecuteNonQuery();
            Con.Close();
            return CargarCl(ID.ToString());
        }
    }
}
