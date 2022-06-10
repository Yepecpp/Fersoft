using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClasesF.Clases_Nom
{
    public class C_Dep 
    {
        public C_Dep()
        {
            Id_Suc = 1;
        }
        private readonly MySqlConnection Con = ConnectionDB.GetConnection();
        public int ID_Dep { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
        public int Id_Suc { get; private set; }
        #region select
        public List<C_Dep> CargarDep(string name)
        {
            List<C_Dep> Lista = new List<C_Dep>();
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_DepS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nomb", MySqlDbType.String,25).Value = name;
           MySqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                Lista.Add(new C_Dep()
                {
                    ID_Dep = Dr.GetInt32(0),
                    Nombre = Dr.GetString(1),
                    Ubicacion = Dr.GetString(2),
                    Telefono = Dr.GetString(3),
                    Id_Suc = Dr.GetInt32(4)
                });
            }
            Con.Close();
            return Lista;
        }
        #endregion
        public int UpdateDep(int id)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_DepU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@Nombre", MySqlDbType.String,25).Value = Nombre;
            cmd.Parameters.Add("@Ubicacion",MySqlDbType.String,60).Value=Ubicacion;
            cmd.Parameters.Add("Telefono",MySqlDbType.String,20).Value = Telefono;
            cmd.Parameters.Add("@Id_Suc", MySqlDbType.Int32).Value = Id_Suc;
            cmd.ExecuteNonQuery();
            Con.Close();
            return id;
        }
        public int InsertDep()
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_DepI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", MySqlDbType.String, 25).Value = Nombre;
            cmd.Parameters.Add("@Ubicacion", MySqlDbType.String, 60).Value = Ubicacion;
            cmd.Parameters.Add("Telefono", MySqlDbType.String, 20).Value = Telefono;
            cmd.Parameters.Add("@Id_Suc", MySqlDbType.Int32).Value = Id_Suc;
           MySqlDataReader Dr = cmd.ExecuteReader();
            var rn = 0;
            while (Dr.Read())
            {
                rn = Dr.GetInt32(0);
            }
            Con.Close();

            return rn;
        }
        public int DeleteDep(int id)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_DepD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
            Con.Close();
            return 0;
        }
    }
}
