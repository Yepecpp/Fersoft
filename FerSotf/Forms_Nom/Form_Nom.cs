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
    public partial class Form_Nom : KryptonForm
    {
        public Form_Nom()
        {
            InitializeComponent();
   
        }
        private void fixfecha()
        {
            FechaIn.MinDate = new C_Nominas().min_date();
            FechaOut.MinDate = FechaIn.MinDate;
            FechaIn.Value = FechaIn.MinDate;
        }

        private void CargarNom(int id)
        {
            CargarNom(id.ToString());
        }
        private void CargarNom(string name)
        {
            string estado = kryptonCheckBox1.Checked ? EstadoP.SelectedItem.ToString() : null;
            var nom = new C_Nominas().CargarNom(name, FechaIn.Value, FechaOut.Value.AddDays(1), estado);
            KDataGrid.DataSource = nom;
            NDataGrid.DataSource = nom;
            
        }
        private void Form_Nom_Load(object sender, EventArgs e)
        {
            CargarNom(0);
            fixfecha();
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CargarNom(0);
        }
        private void setdg(int e)
        {
            if (e == -1) return;
            using (DataGridViewRow ros = KDataGrid.Rows[e])
            {
                TBIDE.Text = ros.Cells[0].Value.ToString();
                L_Nom.Text = $"{L_Nom.Text.Substring(0,L_Nom.Text.IndexOf(':')+1)} {ros.Cells[2].Value.ToString() + " " + ros.Cells[3].Value.ToString()} ";
                L_Puesto.Text = $"{L_Puesto.Text.Substring(0,L_Puesto.Text.IndexOf(':')+1)} {ros.Cells[4].Value.ToString()} ";
                L_Ced.Text = $"{L_Ced.Text.Substring(0,L_Ced.Text.IndexOf(':')+1)} {ros.Cells[1].Value.ToString()} ";
            }
            //nom
            

            using (DataGridViewRow ros = NDataGrid.Rows[e])
            {
                L_IDNom.Text = $"{L_IDNom.Text.Substring(0,L_IDNom.Text.IndexOf(':')+1)} {ros.Cells[0].Value.ToString()}";
                L_SB.Text = $"{L_SB.Text.Substring(0,L_SB.Text.IndexOf(':')+1)} {ros.Cells[3].Value.ToString()} DOP";
                L_ARS.Text = $"{L_ARS.Text.Substring(0,L_ARS.Text.IndexOf(':')+1)} {ros.Cells[5].Value.ToString()} DOP";
                L_DSGS.Text = $"{L_DSGS.Text.Substring(0,L_DSGS.Text.IndexOf(':')+1)} {ros.Cells[6].Value.ToString()} DOP";
                L_AFP.Text = $"{L_AFP.Text.Substring(0,L_AFP.Text.IndexOf(':')+1)} {ros.Cells[4].Value.ToString()} DOP";
                L_ISR.Text = $"{L_ISR.Text.Substring(0,L_ISR.Text.IndexOf(':')+1)} {ros.Cells[8].Value.ToString()} DOP";
                L_SAISR.Text = $"{L_SAISR.Text.Substring(0,L_SAISR.Text.IndexOf(':')+1)} {ros.Cells[7].Value.ToString()} DOP";
                L_Sn.Text = $"{L_Sn.Text.Substring(0,L_Sn.Text.IndexOf(':')+1)} {ros.Cells[9].Value.ToString()} DOP";
                EstadoP.SelectedItem = ros.Cells[10].Value.ToString();

            }
        }

        private void KDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setdg(e.RowIndex);
           
        }

        private void SelectTB_TextChanged(object sender, EventArgs e)
        { 

            if (SelectTB.Text == "") return;
            CargarNom(SelectTB.Text);
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (EstadoP.SelectedIndex == -1) { MessageBox.Show("Seleccione el estado de la nomina", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TBIDE.Tag.ToString() != "Valid") { MessageBox.Show("Ingrese el ID o Cedula del Empleado", "Incompleto",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
            CargarNom(new C_Nominas(int.Parse(TBIDE.Text)) { Fecha=DateTime.Now , Estado_Pago=EstadoP.SelectedItem.ToString()}.InsertNom());
            
        }

        private void TBIDE_TextChanged(object sender, EventArgs e)
        {
            if (!C_Jor.LogEmpleado(TBIDE.Text))
            {
                TBIDE.StateCommon.Border.Color1 = Color.Red;
                TBIDE.StateCommon.Border.Color2 = Color.White;
                TBIDE.Tag = "Invalid";
                return;
            }
            else
            {
                TBIDE.StateCommon.Border.Color1 = Color.Lime;
                TBIDE.StateCommon.Border.Color2 = Color.Gray;

                TBIDE.Tag = "Valid";
            }
            L_UN.Text = $"{L_UN.Text.Substring(0, L_UN.Text.IndexOf(':') + 1)} {new C_Nominas().LastNom(TBIDE.Text)}";

        }
        private void FechaIn_ValueChanged(object sender, EventArgs e)
        {
            CargarNom(0);
        }

        private void FechaOut_ValueChanged(object sender, EventArgs e)
        {
            CargarNom(0);
        }

        private void NDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setdg(e.RowIndex);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (EstadoP.SelectedIndex == -1) { MessageBox.Show("Seleccione el estado de la nomina", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TBIDE.Tag.ToString() != "Valid") { MessageBox.Show("Ingrese el ID o Cedula del Empleado", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            CargarNom(new C_Nominas(int.Parse(TBIDE.Text)) { Estado_Pago = EstadoP.SelectedItem.ToString() }
            .UpdateNom(int.Parse(TBIDE.Text)));

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            new Forms_Nom.RepNom.Nom_RP(FechaIn.Value,FechaOut.Value.AddDays(1)).ShowDialog();
        }
    }
}
