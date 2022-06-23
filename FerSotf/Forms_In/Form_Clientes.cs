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
using ClasesF;
using ClasesF.Clases_Inv;
namespace FerSotf.Forms_In
{
    public partial class Form_Clientes : KryptonForm
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }
       private void CargarDT(string x)
        {
            if (x == "") x = "0";
            KDataGrid.DataSource = C_Cl.CargarCl(x);
        }
        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            CargarDT("0");
        }

        private void KDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)  return;
            DataGridViewRow x = KDataGrid.Rows[e.RowIndex];
            Label_ID.Text = Label_ID.Text.Substring(0, 3) + x.Cells[0].Value.ToString();
            TB_Cedula.Text = x.Cells[1].Value.ToString();
            Tb_RNC.Text = x.Cells[2].Value.ToString();
            TBNombre.Text = x.Cells[3].Value.ToString();
            Tb_Apellido.Text = x.Cells[4].Value.ToString();
            MTextBox_Tel.Text = x.Cells[5].Value.ToString();
            Tb_Email.Text = x.Cells[7].Value.ToString();
            Tb_Ubi.Text = x.Cells[6].Value.ToString();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            KDataGrid.DataSource = new C_Cl()
            {
                Cedula = TB_Cedula.Text,
                RNC = Tb_RNC.Text,
                Nombre = TBNombre.Text,
                Apellido = Tb_Apellido.Text,
                Email = Tb_Email.Text,
                Telefono = MTextBox_Tel.Text,
                Ubicacion = Tb_Ubi.Text
            }.InsertCl();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            KDataGrid.DataSource = new C_Cl()
            {
                ID = int.Parse(Label_ID.Text.Substring(3)),
                Cedula = TB_Cedula.Text,
                RNC = Tb_RNC.Text,
                Nombre = TBNombre.Text,
                Apellido = Tb_Apellido.Text,
                Email = Tb_Email.Text,
                Telefono = MTextBox_Tel.Text,
                Ubicacion = Tb_Ubi.Text
            }.UpdateCl();
        }
    }
}
