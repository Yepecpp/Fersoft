using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace ClasesF.Clases_Inv
{
    public class C_Ven
    {
        public C_Ven()
        {

        }
        private static readonly MySqlConnection Con = ConnectionDB.GetConnection();
        public int ID_Pr { get; set; }
        private C_Prod Prod => C_Prod.CargarProd(ID_Pr.ToString())[0]; 
        public int Cantidad { get; set; }
        public float Total => (float)Cantidad * Prod.Precio;
        public int Id_Fact { get; set; }
        private C_Fact Fact => C_Fact.CargarFact(Id_Fact.ToString())[0];
        public static List<C_Ven> CargarVen(string x )
        {
            List<C_Ven> lista = new List<C_Ven>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_VS", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomb", x);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new C_Ven()
                {
                    ID_Pr = dr.GetInt32(0),
                    Cantidad = dr.GetInt32(1),
                    Id_Fact = dr.GetInt32(2)
                });
            }
            Con.Close();
            return lista;
        }
        public List<C_Ven> InsertV()
        {
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_VI", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Producto", ID_Pr);
            cmd.Parameters.AddWithValue("@Total_V", Cantidad);
            cmd.Parameters.AddWithValue("@Id_Fact", Id_Fact);
            MySqlDataReader dr = cmd.ExecuteReader();
            string ID = null;
            if (dr.Read()){
                ID = dr.GetInt32(0).ToString();
            }else {
                Con.Close();
                return null;
            }
            Con.Close();
            return CargarVen(ID);

        }

    }
}
