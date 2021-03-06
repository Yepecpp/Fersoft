using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace ClasesF.Clases_Inv
{
    public class C_Prod
    {
        public C_Prod()
        {
            Al = 1;
        }
        private static readonly MySqlConnection con = ConnectionDB.GetConnection();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }
        public int Prov { get; set; }
        public string NProv => C_Prov.CargarProv(Prov.ToString())[0].Nombre;
        public string Categoria { get; set; }
        private int Al { get; set; }
        public string Ubi { get; set; }

        public  static List<C_Prod> CargarProd(string x)
        {
            List<C_Prod> lista = new List<C_Prod>();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_PiS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomb", x);
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new C_Prod()
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Marca = lector.GetString(2),
                    Precio = lector.GetFloat(3),
                    Prov = lector.GetInt32(4),
                    Categoria = lector.GetString(5),
                    Al = lector.GetInt32(6),
                    Ubi = lector.GetString(7)
                });
            }
            con.Close();
            return lista;
        }
        public List<C_Prod> InsertarProd()
        {
            
            int id = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_PiI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nomb", Nombre);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            cmd.Parameters.AddWithValue("@idprv", Prov);
            cmd.Parameters.AddWithValue("@Cat", Categoria);
            cmd.Parameters.AddWithValue("@idal", Al);
            cmd.Parameters.AddWithValue("@ubi", Ubi);
            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                id = lector.GetInt32(0);
            }
            con.Close();

            return CargarProd(id.ToString());
        }
        public List<C_Prod> UpdateProd()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_PiU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@Nomb", Nombre);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            cmd.Parameters.AddWithValue("@idprv", Prov);
            cmd.Parameters.AddWithValue("@Cat", Categoria);
            cmd.Parameters.AddWithValue("@idal", Al);
            cmd.Parameters.AddWithValue("@ubi", Ubi);
            cmd.ExecuteNonQuery();
            con.Close();
            return CargarProd(Id.ToString());
        }
    }
}
