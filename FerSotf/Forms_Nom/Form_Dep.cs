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
    public partial class Form_Dep : KryptonForm
    {
        private C_Dep Dep = new C_Dep();
        public Form_Dep()
        {
            InitializeComponent();
        }
        private void setFill(int dis = 0)
        { 
            if (KDataGrid.Rows.Count ==-1) return;
            DataGridViewRow SRow = KDataGrid.Rows[dis];
            Label_ID.Text = Label_ID.Text.Substring(0, 4) + SRow.Cells[0].Value.ToString();
            TextBox_Nom.Text = SRow.Cells[1].Value.ToString();
            TextBox_Dir.Text = SRow.Cells[2].Value.ToString();
            MTextBox_Tel.Mask = "+1 (999) 000-0000";
            MTextBox_Tel.Text = SRow.Cells[3].Value.ToString();
        }
        private void CargarDeps(string name)
        {
            
            KDataGrid.DataSource = Dep.CargarDep(name);

        }
        private void CargarDeps(int id)
        {

            CargarDeps(id.ToString());
        }
        private void Form_Dep_Load(object sender, EventArgs e)
        {
            CargarDeps(0);
            if (KDataGrid.Rows.Count > 0) { setFill(0); }
        }

        private void TextBox_Select_TextChanged(object sender, EventArgs e)
        {
            string texto = TextBox_Select.Text;
            if (string.IsNullOrEmpty(texto) || texto=="") {CargarDeps(0); return; }
            CargarDeps(texto);
            
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (MTextBox_Tel.Tag.ToString() != "Valid" || TextBox_Dir.Text=="" || TextBox_Nom.Text == "")
            {
                MessageBox.Show("Llene los campos antes de ingresar", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            CargarDeps(new C_Dep() { Nombre = TextBox_Nom.Text, Telefono = MTextBox_Tel.Text,
                Ubicacion = TextBox_Dir.Text }.InsertDep());
        }

        private void KDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setFill(e.RowIndex);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            if (MTextBox_Tel.Tag.ToString() != "Valid" || TextBox_Dir.Text == "" || TextBox_Nom.Text == "")
            {
                MessageBox.Show("Llene los campos antes de cambiar", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            CargarDeps(new C_Dep()
            {
                Nombre = TextBox_Nom.Text,
                Telefono = MTextBox_Tel.Text,
                Ubicacion = TextBox_Dir.Text
            }.UpdateDep(int.Parse(Label_ID.Text.Substring(3))));
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            CargarDeps(new C_Dep()
            {
                Nombre = TextBox_Nom.Text,
                Telefono = MTextBox_Tel.Text,
                Ubicacion = TextBox_Dir.Text
            }.DeleteDep(int.Parse(Label_ID.Text.Substring(3))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MTextBox_Tel.Text, MTextBox_Tel.Text.Length.ToString());
        }

        private void MTextBox_Tel_TextChanged(object sender, EventArgs e)
        {
         if (MTextBox_Tel.Mask== "") { MTextBox_Tel.Mask = "+1 (999) 000-0000"; }
          if (MTextBox_Tel.Text.Length < 17) { 
                MTextBox_Tel.StateCommon.Border.Color1 = Color.Red;
                MTextBox_Tel.StateCommon.Border.Color2 = Color.Red;
                MTextBox_Tel.Tag = "Invalid";
            }
          else {
                MTextBox_Tel.StateCommon.Border.Color1 = Color.White;
                MTextBox_Tel.StateCommon.Border.Color2 = Color.White;
                MTextBox_Tel.Tag = "Valid";
            }
        }

        private void MTextBox_Tel_Enter(object sender, EventArgs e)
        {
            if (MTextBox_Tel.Text == "" || MTextBox_Tel.Text == "Telefono") MTextBox_Tel.Mask = "+1 (999) 000-0000";
        }

        private void MTextBox_Tel_Leave(object sender, EventArgs e)
        {
            if (MTextBox_Tel.Text == "+1 (   )    -" || MTextBox_Tel.Text == "") { MTextBox_Tel.Mask = ""; MTextBox_Tel.Text = "Telefono"; }
        }

        private void Label_ID_TextChanged(object sender, EventArgs e)
        {
            if (Label_ID.Text.Length == Label_ID.Text.IndexOf(':') + 1) { ButtonUpdate.Visible = false; } else { ButtonUpdate.Visible = true; }
        }

        private void MTextBox_Tel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
