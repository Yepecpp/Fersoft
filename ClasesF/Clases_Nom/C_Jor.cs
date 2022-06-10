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
    public class C_Jor

    {
        public C_Jor()
        { 
        }
            public C_Jor(C_Empleados emp)
        {
            ID_E = emp.ID_E;
            Nombre = emp.Nombre;
            Apellido = emp.Apellido;
            Horario = emp.Horario;
        }
        public int ID_E { get; set; }
        public string Horario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<DateTime> Entrada { get; set; }
        public Nullable<DateTime> Salida { get; set; }
       
        private readonly MySqlConnection Con = ConnectionDB.GetConnection();
        #region Selects
        public List<C_Jor> CargarJor(string text, DateTime fi, DateTime fo)
        {
            List<C_Jor> lista = new List<C_Jor>();
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_JSN";
            cmd.Parameters.Add("@str", MySqlDbType.String, 25).Value = text;
            cmd.Parameters.Add("@Fin", MySqlDbType.DateTime).Value = fi;
            cmd.Parameters.Add("@Fout", MySqlDbType.DateTime).Value = fo;
           MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                /*Console.WriteLine(dr.GetString(5));
                Console.WriteLine(dr.GetString(5));*/
                lista.Add(new C_Jor()
                {
                   ID_E = dr.GetInt32(0),
                   Nombre = dr.GetString(1),
                   Apellido = dr.GetString(2),
                    Horario = dr.GetString(3),
                    Entrada = dr.GetDateTime(4),

                    Salida = dr.IsDBNull(5)? null: dr.GetDateTime(5),
                });
            }
            return lista;
        }
        #endregion
        #region Ponchar
        public void J_Ponchar(string id ,DateTime fi) {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_JP";
            cmd.Parameters.Add("@str", MySqlDbType.String,25).Value=id;
            cmd.Parameters.Add("@fechai",MySqlDbType.DateTime).Value=fi;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            Con.Close();
        }
        #endregion
        #region hours 
        public C_Jor(DateTime en, DateTime sal) {
            Entrada=en;
            Salida=sal;
        }
        public static double LastNom(List<C_Jor> Xn)
        {
            double Horas = 0;
            foreach (C_Jor Jor in Xn){
              TimeSpan? xss = Jor.Salida - Jor.Entrada;
                Horas += xss.Value.Hours;
               Horas+= (double)xss.Value.Minutes/60;
            } 
            return Math.Round(Horas,1);
        }
        public static bool LogEmpleado(string l)
        {
            MySqlConnection Cond = ConnectionDB.GetConnection();
            bool ls = false;
            MySqlCommand cmd = Cond.CreateCommand();
            cmd.CommandText = "select top 1 E.ID_E from N_Empleados E where @str = E.Cedula or CONVERT(nvarchar, E.ID_E)=@str";
            cmd.Parameters.Add("@str", MySqlDbType.String,25).Value = l;
            cmd.CommandType = CommandType.Text;
            Cond.Open();
           MySqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())

            {
                ls = true;
            }
            Cond.Close();
            return ls;
        }
       
        /* if (dt.CompareTo(DateTime.Now) < 0)
            {
                string [] sk = hr.Split('-');
               
                int hori = int.Parse(sk[0]);
                int horo = int.Parse(sk[1])<=12? int.Parse(sk[1])+12: int.Parse(sk[1]);
                int hourd = horo-hori;

                
               Daysd = (DateTime.Now-dt).Days-((DateTime.Now - dt).Days/7);
                Hours = (DateTime.Now-dt).Hours;
                Hours = Hours > hori ? 
                    Hours > horo ? (Hours - hori) - (Hours - horo) : Hours - hori 
                    : 0;
                NHPD = Daysd * 8;
                Hours += hourd * Daysd;
            }*/
        #endregion
    }
}
