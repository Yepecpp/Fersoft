using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace ClasesF.Clases_Nom
{

        public class C_Empleados
    {

        public int ID_E { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
       
        public string Puesto { get; set; }

        public Nullable<double> SueldoXH { get; set; }
        public Nullable<double> SueldoXHE { get; set; }
        public string Horario { get; set; }
        public string Telefono { get; set; }
        public int Id_Dep { get; set; }
        
    }
    public partial class V_EmpED : C_Empleados
    {
       
        public V_EmpED()
        {

        }
        
        private readonly MySqlConnection Con = ConnectionDB.GetConnection();

        public string Nom_Dep { get; set; }
        public string Nom_Suc { get; set; }
        public string Nom_Emp { get; set; }
        #region selects
        public List<V_EmpED> CargarEmpleado(string Letra)
        {
            Con.Open();
            List<V_EmpED> Lista = new List<V_EmpED>();
            MySqlCommand cmd = Con.CreateCommand();
                cmd.CommandText = "SP_ES";
                cmd.Parameters.Add("@nomb", MySqlDbType.String,25).Value = Letra;
           
            cmd.CommandType = CommandType.StoredProcedure;
           MySqlDataReader Dr = cmd.ExecuteReader();

            while (Dr.Read())

            {
                Lista.Add(new V_EmpED()
                {
                    ID_E = Dr.GetInt32(0),
                    Cedula = Dr.GetString(1),
                    Nombre = Dr.GetString(2),
                    Apellido = Dr.GetString(3),
                    Puesto = Dr.GetString(4),
                    SueldoXH = Dr.GetDouble(5),
                    SueldoXHE = Dr.GetDouble(6),
                    Horario = Dr.GetString(7),
                    Telefono= Dr.GetString(8),
                    Id_Dep = Dr.GetInt32(9),
                    Nom_Dep = Dr.GetString(10),
                    Nom_Suc = Dr.GetString(11),
                    Nom_Emp = Dr.GetString(12)
                });
            }
            Con.Close();
            return Lista;
        }
      
        #endregion
        public int UpdateEmp(int id) {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_EU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@Cedula1", MySqlDbType.String, 20).Value = Cedula;
            cmd.Parameters.Add("@Nombre1", MySqlDbType.String, 25).Value = Nombre;
            cmd.Parameters.Add("@Apellido1", MySqlDbType.String, 25).Value = Apellido;
            cmd.Parameters.Add("@Puesto1", MySqlDbType.String, 25).Value = Puesto;
            cmd.Parameters.Add("@SueldoXH1", MySqlDbType.Float).Value = SueldoXH;
            cmd.Parameters.Add("@SueldoXHE1", MySqlDbType.Float).Value = SueldoXHE;
            cmd.Parameters.Add("@Telefono1", MySqlDbType.String, 30).Value = Telefono;
            cmd.Parameters.Add("@Horario1", MySqlDbType.String, 30).Value = Horario;
            cmd.Parameters.Add("@Id_dep1", MySqlDbType.Int32).Value = Id_Dep;
            cmd.ExecuteNonQuery();
            Con.Close();
            return id;
        }
        public int InsertEmp()
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_EI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Cedula", MySqlDbType.String, 20).Value = Cedula;
            cmd.Parameters.Add("@Nombre", MySqlDbType.String, 25).Value = Nombre;
            cmd.Parameters.Add("@Apellido", MySqlDbType.String, 25).Value = Apellido;
            cmd.Parameters.Add("@Puesto", MySqlDbType.String, 25).Value = Puesto;
            cmd.Parameters.Add("@SueldoXH", MySqlDbType.Float).Value = SueldoXH;
            cmd.Parameters.Add("@SueldoXHE", MySqlDbType.Float).Value = SueldoXHE;
            cmd.Parameters.Add("@Horario", MySqlDbType.String, 30).Value = Horario;
            cmd.Parameters.Add("@Telefono", MySqlDbType.String, 30).Value = Telefono;
            cmd.Parameters.Add("@Id_dep", MySqlDbType.Int32).Value = Id_Dep;
           MySqlDataReader Dr= cmd.ExecuteReader();
            var rn = 0;
            while (Dr.Read())
            {
                rn= Dr.GetInt32(0);
            }
            Con.Close();

            return rn;
        }
        public int DelEmp(int id)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_ED";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
            Con.Close();
            return 0;
        }
       
        }
}
