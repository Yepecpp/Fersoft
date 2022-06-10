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
    
    public class C_Nominas
    {
        public C_Nominas()
        {

        }
        public int Id_Nom { get; set; }
        public int Id_E { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Puesto { get; set; }
        public Nullable<double> PXH { get; set; }
        public Nullable<double> PXHE{ get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<double> Horas { get; set; }
        private int NHoras => (int)Horas - EHoras;
        private int EHoras => Horas > NHPD ? (int)Horas - NHPD : 0;
        private int NHPD { get; set; }  
        public Nullable<double> Total_Salario { get; set; }
        public Nullable<double> AFP => Total_Salario * 0.0287;
        public Nullable<double> ARS => Total_Salario * 0.0304;
        public Nullable<double> D_SGS { get; set; }
        public Nullable<double> SA_ISR => Total_Salario - D_SGS;
        public Nullable<double> ISR { get; set; }
        public Nullable<double> S_Neto { get; set; }
        public string Estado_Pago { get; set; }
        private readonly MySqlConnection Con = ConnectionDB.GetConnection();
        #region selects
        public List<C_Nominas> CargarNom(string x, DateTime fin, DateTime fout, string estado)
        {
            List<C_Nominas> Lista = new List<C_Nominas>();
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = estado != null? "SP_NomSE":"SP_NomS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nomb", MySqlDbType.String,25).Value = x;
            cmd.Parameters.Add("@Fin", MySqlDbType.Date).Value = fin;
            cmd.Parameters.Add("@Fout", MySqlDbType.DateTime).Value = fout;
             if (estado != null)
            cmd.Parameters.Add("@estado", MySqlDbType.String, 10).Value=estado;
           
           MySqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                Lista.Add(new C_Nominas()
                {
                    Id_Nom = Dr.GetInt32(0),
                    Id_E = Dr.GetInt32(1),
                    Nombre = Dr.GetString(2),
                    Apellido = Dr.GetString(3),
                    Cedula = Dr.GetString(4),
                    Puesto = Dr.GetString(5),
                    PXH = Math.Round(Dr.GetDouble(6)),
                    PXHE = Math.Round(Dr.GetDouble(7)),
                    Fecha = Dr.GetDateTime(8),
                    Horas = Dr.GetInt32(9),
                    Total_Salario = Math.Round(Dr.GetDouble(10)),
                    D_SGS = Math.Round(Dr.GetDouble(11)),
                    ISR = Math.Round(Dr.GetDouble(12)),
                    S_Neto = Math.Round(Dr.GetDouble(13)),
                    Estado_Pago = Dr.GetString(14)
                });
            }
            Con.Close();
            return Lista;
        }
        #endregion
        public C_Nominas(int id)
        {
            var ss = fixvemp(id.ToString());
            if (ss==null) return;
            
                PXHE = ss.SueldoXHE;
                PXH = ss.SueldoXH;
            
            Id_E = id;
            Horas=LastNom(id.ToString(), ss);
            Total_Salario = (NHoras*PXH) + (EHoras*PXHE);
            D_SGS = AFP + ARS;
            if (SA_ISR >= 72260.25)
            {
                ISR = ((SA_ISR - 72260.25) * 0.25) + 6647.93;
            }
            else if (SA_ISR >= 52027.43)
            {
                ISR = ((SA_ISR - 52027.43) * 0.20) + 2601.36;
            }
            else if (SA_ISR >= 34685.00)
            {
                ISR = (SA_ISR - 34685.00) * 0.15;
            }
            else ISR = 0;
            S_Neto = SA_ISR - ISR;
        }
         public DateTime min_date() {
            DateTime dt = DateTime.Now;
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "select top 1 v.Fecha from V_N_Nomina V order by V.Fecha asc";
            cmd.CommandType = CommandType.Text;
           MySqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                dt = Dr.GetDateTime(0);
            }
            Con.Close();
            return dt;
           
        }
        private V_EmpED fixvemp(string id)
        {
            MySqlConnection Cond = ConnectionDB.GetConnection();
            V_EmpED ls = null;
            MySqlCommand cmd = Cond.CreateCommand();
            cmd.CommandText = "select * from N_V_EmpED  E where @str = E.Cedula or CONVERT(nvarchar, E.ID_E)=@str";
            cmd.Parameters.Add("@str", MySqlDbType.String, 25).Value = id;
            cmd.CommandType = CommandType.Text;
            Cond.Open();
           MySqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())

            {
                ls=new V_EmpED()
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
            return ls;
        }
        public double LastNom (string id, V_EmpED d=null)
        {
            if (d == null)
            {
                d=fixvemp(id);
                if (d == null) { return 0; }
            }
            
            DateTime fout = DateTime.Now;
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_NomLN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", MySqlDbType.String, 25).Value = id;
            cmd.Parameters.Add("@Fin", MySqlDbType.DateTime).Value = fout;
            List<C_Jor> Xn = new List<C_Jor>(); 
           MySqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                Xn.Add(new C_Jor(Dr.GetDateTime(0), Dr.GetDateTime(1)));
            }
            Con.Close();
            Dr.Close();
            cmd.Dispose();

            int Days = Xn.Count; 
            double Hours = C_Jor.LastNom(Xn);
            string[] sk = d.Horario.Split('-');
            int hori = int.Parse(sk[0]) < 12 ? int.Parse(sk[0]) + 12 : int.Parse(sk[0]); ;
            int horo = int.Parse(sk[1]) < 12 ? int.Parse(sk[1]) + 12 : int.Parse(sk[1]);
            int hourd = horo - hori;
            NHPD = Days * hourd;
            return Hours;
        }
        public int InsertNom()
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_NomI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id_E", MySqlDbType.Int32).Value = Id_E;
            cmd.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = Fecha;
            cmd.Parameters.Add("@Horas", MySqlDbType.Int32).Value = Horas;
            cmd.Parameters.Add("@Total_Salario", MySqlDbType.Float).Value =Total_Salario;
            cmd.Parameters.Add("@D_SGS", MySqlDbType.Float).Value = D_SGS;
            cmd.Parameters.Add("@IRS", MySqlDbType.Float).Value = ISR;
            cmd.Parameters.Add("@S_Neto", MySqlDbType.Float).Value =S_Neto;
            cmd.Parameters.Add("@Estado_pago", MySqlDbType.String,10).Value = Estado_Pago;
           MySqlDataReader Dr = cmd.ExecuteReader();
            var rn = 0;
            while (Dr.Read())
            {
                rn = Dr.GetInt32(0);
            }
            Con.Close();

            return rn;
        }
        public int UpdateNom(int id)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_NomU";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Estado_pago", MySqlDbType.String, 10).Value = Estado_Pago;
            cmd.ExecuteNonQuery();
            Con.Close();
            return id;
        }
        private int OUpdateNom(int id)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_NomU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@Id_E", MySqlDbType.Int32).Value = Id_E;
            cmd.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = Fecha;
            cmd.Parameters.Add("@Horas", MySqlDbType.Int32).Value = Horas;
            cmd.Parameters.Add("@Total_Salario", MySqlDbType.Float).Value = Total_Salario;
            cmd.Parameters.Add("@D_SGS", MySqlDbType.Float).Value = D_SGS;
            cmd.Parameters.Add("@IRS", MySqlDbType.Float).Value = ISR;
            cmd.Parameters.Add("@S_Neto", MySqlDbType.Float).Value = S_Neto;
            cmd.Parameters.Add("@Estado_pago", MySqlDbType.String, 10).Value = Estado_Pago;
            cmd.ExecuteNonQuery();
            Con.Close();
            return id;
        }
        public int DeleteNom(int id)
        {
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "SP_NomD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
           MySqlDataReader Dr = cmd.ExecuteReader();
            Con.Close();
            return id;
        }
    }

}
