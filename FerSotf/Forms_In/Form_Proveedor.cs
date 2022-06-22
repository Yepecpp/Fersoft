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
using ClasesF.Clases_Inv;

namespace FerSotf.Forms_In
{
    public partial class Form_Proveedor : KryptonForm
    {
        public Form_Proveedor()
        {
            InitializeComponent();
        }
        private void CargarDT(string x)
        {
            if (x == "") x = "0";
            KDataGrid.DataSource = C_Prov.CargarProv(x); 
        }
        private void TextBox_Select_TextChanged(object sender, EventArgs e)
        {
            CargarDT(TextBox_Select.Text);
        }

        private void KDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow SRow = KDataGrid.Rows[e.RowIndex];
            Label_ID.Text = Label_ID.Text.Substring(0, 3) + SRow.Cells[0].Value.ToString();
            TBNombre.Text = SRow.Cells[1].Value.ToString();
            Tb_Email.Text = SRow.Cells[3].Value.ToString();
            TB_Ag.Text = SRow.Cells[4].Value.ToString();
            MTextBox_Tel.Text = SRow.Cells[2].Value.ToString();
        }
        private bool check()
        {
            if (TBNombre.Text == "" || TB_Ag.Text == "" || Tb_Email.Text == "" || MTextBox_Tel.Text == "")
            {
                return false;
            }
            return true;
        }
        private void ButtonInsert_Click(object sender, EventArgs e)
        {
             if (check())
            {
                KDataGrid.DataSource =  new C_Prov() { Nombre = TBNombre.Text, Agente = TB_Ag.Text,
                    Email = Tb_Email.Text,
                    Telefono = MTextBox_Tel.Text
                }.InsertProv();
            }else
            {
                MessageBox.Show("Complete los campos antes de Ingresar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (Label_ID.Text.Length<3)
            if (check())
            {
                KDataGrid.DataSource = new C_Prov()
                {
                    ID = int.Parse(Label_ID.Text.Substring(3)),
                    Nombre = TBNombre.Text,
                    Agente = TB_Ag.Text,
                    Email = Tb_Email.Text,
                    Telefono = MTextBox_Tel.Text
                }.UpdateProv();
            }
            else
            {
                MessageBox.Show("Complete los campos antes de actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else MessageBox.Show("Seleccione un ID antes de actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void KDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
