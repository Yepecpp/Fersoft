using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace ClasesF.Clases_Nom
{
    public enum Roles : Int16
    {
        Admin = 0,
        Supervisor = 1,
        Empleado = 2
    }
    public class Encrypt
    {
        public static string GetSHA256(string str)
        {
            if (str == null) return null;
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] Stream = null;
            StringBuilder sb = new StringBuilder();
            Stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < Stream.Length; i++)

                sb.AppendFormat("{0:x2}", Stream[i]);
            return sb.ToString();
        }
    }
    public class C_Usuario
    {
        private V_EmpED Emp { get; set; }
        public int ID_emp { get => Emp.ID_E; set => Emp = LogEmpleado(value); } 
        private string _Pass;
        public string Nombre => $"{Emp.Nombre} {Emp.Apellido}";
        public string Puesto => Emp.Puesto;
        public string Cedula => Emp.Cedula;
        public string Dep => Emp.Nom_Dep;
        private string Empr => Emp.Nom_Emp;
        private string Suc => Emp.Nom_Suc;
        public string Pass { get => _Pass; set => _Pass = Encrypt.GetSHA256(value); }
        public Roles Rol { get; set; }
        static private readonly MySqlConnection Con = ConnectionDB.GetConnection();
         //private readonly MySqlConnection Conn = ConnectionDB.GetConnection();

        public C_Usuario()
        {

        }
        public C_Usuario Log_in(string user, string pas)
        {
            C_Usuario usu = null;
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LES";
            cmd.Parameters.Add("@Cedula", MySqlDbType.String,25).Value = user;
          MySqlDataReader lr = cmd.ExecuteReader();
            if (lr.Read())
            {
                Pass = pas;
                if (Pass ==lr.GetString(2))
                    usu = new C_Usuario()
                    {

                        ID_emp =lr.GetInt32(0),
                        _Pass =lr.GetString(2),
                        Rol = (Roles)lr.GetInt16(1)
                    };
            }
            Con.Close();
            return usu;
        }
        public static List<C_Usuario> CargarUsu(string s)
        {
            List<C_Usuario> usu = new List<C_Usuario>();
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_US";
            cmd.Parameters.Add("@Str", MySqlDbType.String, 25).Value = s;
          MySqlDataReader lr = cmd.ExecuteReader();
           while (lr.Read())
            {
                    usu.Add(new C_Usuario()
                    {

                        ID_emp =lr.GetInt32(0),
                        Rol = (Roles)lr.GetInt16(1)
                    });
            }
            Con.Close();
            return usu;
        }
        public static List<C_Usuario> UpdateUsu(int id,string s)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UU";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@Str", MySqlDbType.String, 250).Value = s.Length<2? s : Encrypt.GetSHA256(s);
           cmd.ExecuteNonQuery();
            Con.Close();
            return CargarUsu(id.ToString());
        }
        public static List<C_Usuario> InUsu(int id,Int16 sd, string s)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_IU";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@rol", MySqlDbType.Int16).Value = sd;
            cmd.Parameters.Add("@pass", MySqlDbType.String, 250).Value = Encrypt.GetSHA256(s);
            cmd.ExecuteNonQuery();
            Con.Close();
            return CargarUsu(id.ToString());
        }
        private static V_EmpED LogEmpleado(int l)
        {
            MySqlConnection Cond = ConnectionDB.GetConnection();
            V_EmpED Lista = new V_EmpED();
            MySqlCommand cmd = Cond.CreateCommand();
            cmd.CommandText = "SP_LE";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value =l;
            cmd.CommandType = CommandType.StoredProcedure;
            Cond.Open();
           MySqlDataReader Dr = cmd.ExecuteReader();

            if(Dr.Read())

            {
                Lista=new V_EmpED()
                {
                    ID_E = Dr.GetInt32(0),
                    Cedula = Dr.GetString(1),
                    Nombre = Dr.GetString(2),
                    Apellido = Dr.GetString(3),
                    Puesto = Dr.GetString(4),
                    SueldoXH = Dr.GetDouble(5),
                    SueldoXHE = Dr.GetDouble(6),
                    Horario = Dr.GetString(7),
                    Telefono = Dr.GetString(8),
                    Id_Dep = Dr.GetInt32(9),
                    Nom_Dep = Dr.GetString(10),
                    Nom_Suc = Dr.GetString(11),
                    Nom_Emp = Dr.GetString(12)
                };
            }
            Cond.Close();
            return Lista;
        }
    }
}
