using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ClasesF.Clases_Nom;

namespace FerSotf.Forms_Nom
{
    public partial class Form_J : KryptonForm
    {
        public Form_J()
        {
            InitializeComponent();
        }
        private void CargarDG(string text)
        {
            NDataGrid.DataSource = new C_Jor().CargarJor(text, FechaI.Value, FechaO.Value.AddDays(1));
        }
        private void TB_S_TextChanged(object sender, EventArgs e)
        {
            if (TB_S.Text ==" ") { CargarDG("0"); return; }
            CargarDG(TB_S.Text);
        }

        private void B_Ins_Click(object sender, EventArgs e)
        {
            if (TB_ID.Tag.ToString() != "Valid") { MessageBox.Show("Ingrese el ID o Cedula del empleado correcto", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;}
            new C_Jor().J_Ponchar(TB_ID.Text, DateTime.Now);
            CargarDG(TB_ID.Text);
        }

        private void Form_J_Load(object sender, EventArgs e)
        {
           CargarDG("0");
        }

        private void TB_ID_TextChanged(object sender, EventArgs e)
        {
           if (!C_Jor.LogEmpleado(TB_ID.Text)) {
                TB_ID.StateCommon.Border.Color1 = Color.Red;
                TB_ID.StateCommon.Border.Color2 = Color.Red;
                TB_ID.Tag = "Invalid";
            }else
            {
                TB_ID.StateCommon.Border.Color1 = Color.White;
                TB_ID.StateCommon.Border.Color2 = Color.White;
                TB_ID.Tag = "Valid";
            }
        }
    }
}
