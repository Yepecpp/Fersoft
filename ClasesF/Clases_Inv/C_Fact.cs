using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace ClasesF.Clases_Inv
{
    public class C_Fact
    {
        public C_Fact()
        {

        }
        private static readonly MySqlConnection Con = ConnectionDB.GetConnection();
        public int ID { get; set; }
        public int ID_Cl { get; set; }
        private C_Cl Client => C_Cl.CargarCl(ID_Cl.ToString())[0];
        public float Total { get; set; }
        public float ITBIS { get; set; }
        public DateTime Fecha { get; set; }
        public int Uid { get; set; }
        private Clases_Nom.C_Usuario Usuario => Clases_Nom.C_Usuario.CargarUsu(Uid.ToString())[0];
        public static List<C_Fact> CargarFact(string x)
        {
            List<C_Fact> lista = new List<C_Fact>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_FACS", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomb", x);
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new C_Fact()
                {
                    ID = lector.GetInt32(0),
                    ID_Cl = lector.GetInt32(1),
                    Total = lector.GetFloat(2),
                    ITBIS = lector.GetFloat(3),
                    Fecha = lector.GetDateTime(4),
                    Uid = lector.GetInt32(5)
                });
            }
            Con.Close();
            return lista;
        }
        public List<C_Fact> InsertF()
        {
            List<C_Fact> lista = new List<C_Fact>();
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_FI", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Cliente", ID_Cl);
            cmd.Parameters.AddWithValue("@MontoTotal", Total);
            cmd.Parameters.AddWithValue("@TotalItbs", ITBIS);
            cmd.Parameters.AddWithValue("@Fecha_emitida", Fecha);
            cmd.Parameters.AddWithValue("@Id_U", Uid);
            MySqlDataReader lector = cmd.ExecuteReader();
            string ID = null;
            if (lector.Read())
                ID = lector.GetInt32(0).ToString();
            else{Con.Close(); return null;}
            Con.Close();
            return CargarFact(ID);
        }
    }
}
