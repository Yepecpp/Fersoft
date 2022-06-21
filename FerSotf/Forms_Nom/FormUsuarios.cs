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
    public partial class FormUsuarios : KryptonForm
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CBRol.Items.AddRange(new string[]{ Roles.Admin.ToString(), Roles.Supervisor.ToString(), Roles.Empleado.ToString()});
            Cargar("0");

        }
        private void Cargar(string s)
        {
            KDataGrid.DataSource = C_Usuario.CargarUsu(s);
        }
        private void TB_S_TextChanged(object sender, EventArgs e)
        {
            Cargar(TB_S.Text==""? "0": TB_S.Text);
        }
        bool busy = false;
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!busy)
            {
                this.Controls.OfType<KryptonButton>().All(button => button.Enabled = false);
                ButtonUpdate.Enabled = true;
                B_C.Visible = true;
                B_C.Enabled = true;
                busy = true;
            }
            else
            {
                if (TB_ID.Tag.ToString() != "Valid") { MessageBox.Show("Ingrese el id del empleado que cambiara su rol"); return; }
                this.Controls.OfType<KryptonButton>().All(button => button.Enabled = true);
                B_C.Visible = false;
                KDataGrid.DataSource = C_Usuario.UpdateUsu(int.Parse(TB_ID.Text), CBRol.SelectedIndex.ToString());
                busy = false;
                CBRol.Visible = false;
            }
        }

        private void B_UP_Click(object sender, EventArgs e)
        {
            if (!busy)
            {
                this.Controls.OfType<KryptonButton>().All(button => button.Enabled = false);
                B_UP.Enabled = true;
                TBPass.Visible = true;
                B_C.Visible=true;
                B_C.Enabled=true;
                busy = true;
            }
            else
            {
                if (TB_ID.Tag.ToString() != "Valid") { MessageBox.Show("Ingrese el id del empleado que cambiara su contraseña");  return; }
                KDataGrid.DataSource= C_Usuario.UpdateUsu(int.Parse(TB_ID.Text), TBPass.Text);
                this.Controls.OfType<KryptonButton>().All(button => button.Enabled = true);
                B_C.Visible = false;
                busy = false;
                TBPass.Visible = false;

            }
        }

        private void B_C_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<KryptonButton>().All(button => button.Enabled = true);
            busy = false;
            B_C.Visible = false;
            CBRol.Visible = false;
            TBPass.Visible = false;
        }

        private void KDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_ID.Text=KDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        C_Usuario u = new C_Usuario();
        private bool DTS (int x)
        {
            u =new C_Usuario() { ID_emp=x};
            if (u.Cedula == null) { MessageBox.Show("El id no es valido"); return false; }
            CBRol.SelectedIndex = (int)u.Rol;
            return true;
        }
        private void TB_ID_TextChanged(object sender, EventArgs e)
        {
            if (TB_ID.Text.All(char.IsNumber) && TB_ID.Text!="")
            {
                if (DTS(int.Parse(TB_ID.Text)))
                {
                    TB_ID.Tag = "Valid";
                }else TB_ID.Tag = "Invalid";
            }
            else { TB_ID.Tag = "Invalid";}
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (!busy)
            {
                this.Controls.OfType<KryptonButton>().All(button => button.Enabled = false);
                ButtonInsert.Enabled = true;
                TBPass.Visible = true;
                B_C.Visible = true;
                B_C.Enabled = true;
                busy = true;
            }
            else
            {
                if (TB_ID.Tag.ToString() != "Valid") { MessageBox.Show("Ingrese el id del empleado que cambiara su contraseña"); return; }
                if (C_Usuario.CargarUsu(TB_ID.Text).Count > 0) { MessageBox.Show("El id ya existe"); return; }
                KDataGrid.DataSource = C_Usuario.InUsu(int.Parse(TB_ID.Text), (Int16)CBRol.SelectedIndex,TBPass.Text);
                this.Controls.OfType<KryptonButton>().All(button => button.Enabled = true);
                B_C.Visible = false;
                busy = false;
            }
        }
    }
}
