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
    public partial class Form_Emp : KryptonForm
    {
        public Form_Emp()
        {
            InitializeComponent();
        }
        private void setFill(int e)
        {
            if (KDataGrid.Rows.Count < 1) return;
            DataGridViewRow SRow = KDataGrid.Rows[e];
            Label_ID.Text=Label_ID.Text.Substring(0,3)+ SRow.Cells[0].Value;
            MTBCedula.Mask = "000-0000000-0";
            MTBCedula.Text=SRow.Cells[1].Value.ToString();
            TBNombre.Text = SRow.Cells[2].Value.ToString();
            TBAP.Text=SRow.Cells[3].Value.ToString(); 
           TBPuesto.Text = SRow.Cells[4].Value.ToString();;
           TBSPH.Text = SRow.Cells[5].Value.ToString();
           TBSPHE.Text = SRow.Cells[6].Value.ToString();
           TBHorario.Text = SRow.Cells[7].Value.ToString();
           CBDep.SelectedIndex = int.Parse(SRow.Cells[9].Value.ToString())-1;
            MTextBox_Tel.Mask = "+1 (999) 000-0000";
            MTextBox_Tel.Text = SRow.Cells[10].Value.ToString();
        }
        #region selects
        private void CargarEmp(int id)
        {
            KDataGrid.DataSource = new V_EmpED().CargarEmpleado(id.ToString());
            setFill(0);
        }
        private void CargarEmp(string str)
        {
            KDataGrid.DataSource = new V_EmpED().CargarEmpleado(str);
            setFill(0);
        }
        #endregion
        private int DEPGET()
        {
            return list[CBDep.SelectedIndex];
        }
        List<int> list = new List<int>();
        private void InsertCB()
        {
       
            foreach (C_Dep str in new C_Dep().CargarDep(0.ToString()))
            {
                CBDep.Items.Add(str.Nombre);
                list.Add(str.ID_Dep);
            }
        }
        private void InsertEmp()
        {
            CargarEmp(new V_EmpED()
            {
                Nombre = TBNombre.Text,
                Apellido = TBAP.Text,
                SueldoXH = double.Parse(TBSPH.Text),
                SueldoXHE = double.Parse(TBSPHE.Text),
                Horario = TBHorario.Text,
                Cedula = MTBCedula.Text,
                Id_Dep = DEPGET(),
                Puesto = TBPuesto.Text,
                Telefono = MTextBox_Tel.Text

            }.InsertEmp()) ;
        }
        private void KDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setFill(e.RowIndex);
        }

        private void TextBox_Select_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_Select.Text == "") { CargarEmp(0); return; }

            CargarEmp(TextBox_Select.Text);
        }

        private void Form_Emp_Load(object sender, EventArgs e)
        {
            InsertCB();
            CargarEmp(0);
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (CBDep.SelectedIndex == -1 ||
            TBNombre.Text ==""||
            TBAP.Text ==""||
            TBPuesto.Text ==""|| 
            TBSPH.Text ==""||
            TBSPHE.Text ==""||
            TBHorario.Text ==""||
            MTBCedula.Tag.ToString() !="Valid" ||
            MTextBox_Tel.Tag.ToString() != "Valid"
                )
            {
                MessageBox.Show("Llene todos los campos para poder ingresar el empleado", "Incompleto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            InsertEmp();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (CBDep.SelectedIndex == -1 ||
          TBNombre.Text == "" ||
          TBAP.Text == "" ||
          TBPuesto.Text == "" ||
          TBSPH.Text == "" ||
          TBSPHE.Text == "" ||
          TBHorario.Text == "" ||
          MTBCedula.Tag.ToString() != "Valid" ||
          MTextBox_Tel.Tag.ToString() != "Valid"
              )
            {
                MessageBox.Show("Llene todos los campos para poder ingresar el empleado", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CargarEmp(new V_EmpED()
            {
                Nombre = TBNombre.Text,
                Apellido = TBAP.Text,
                SueldoXH = double.Parse(TBSPH.Text),
                SueldoXHE = double.Parse(TBSPHE.Text),
                Horario = TBHorario.Text,
                Cedula = MTBCedula.Text,
                Id_Dep = DEPGET(),
                Puesto = TBPuesto.Text,
                Telefono= MTextBox_Tel.Text
            }.UpdateEmp(int.Parse(Label_ID.Text.Substring(3))));
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            CargarEmp(new V_EmpED().DelEmp(int.Parse(Label_ID.Text.Substring(3))));
        }

        private void MTextBox_Tel_Enter(object sender, EventArgs e)
        {
            if (MTextBox_Tel.Text == "" || MTextBox_Tel.Text == "Telefono") MTextBox_Tel.Mask = "+1 (999) 000-0000";
        }

        private void MTextBox_Tel_Leave(object sender, EventArgs e)
        {
            if (MTextBox_Tel.Text == "+1 (   )    -" || MTextBox_Tel.Text == "") { MTextBox_Tel.Mask = ""; MTextBox_Tel.Text = "Telefono"; }
        }

        private void MTextBox_Tel_TextChanged(object sender, EventArgs e)
        {
            if (MTextBox_Tel.Mask == "") { MTextBox_Tel.Mask = "+1 (999) 000-0000"; }
            if (MTextBox_Tel.Text.Length < 17)
            {
                MTextBox_Tel.StateCommon.Border.Color1 = Color.Red;
                MTextBox_Tel.StateCommon.Border.Color2 = Color.Red;
                MTextBox_Tel.Tag = "Invalid";
            }
            else
            {
                MTextBox_Tel.StateCommon.Border.Color1 = Color.White;
                MTextBox_Tel.StateCommon.Border.Color2 = Color.White;
                MTextBox_Tel.Tag = "Valid";
            }
        }

        private void Label_ID_TextChanged(object sender, EventArgs e)
        {
            if (Label_ID.Text.Length == Label_ID.Text.IndexOf(':') + 1)
            {
                ButtonUpdate.Visible = false;
            }else
            {
                ButtonUpdate.Visible = true;
            }
        }

        private void MTBCedula_Leave(object sender, EventArgs e)
        {
            if (MTBCedula.Text == "   -       -" || MTBCedula.Text == "") { MTBCedula.Mask = ""; MTBCedula.Text = "Cedula"; }
        }
        private void MTBCedula_Enter(object sender, EventArgs e)
        {
            if (MTBCedula.Text == "" || MTBCedula.Text == "Telefono") MTBCedula.Mask = "000-0000000-0";
        }

        private void MTBCedula_TextChanged(object sender, EventArgs e)
        {
            if (MTBCedula.Mask == "") { MTBCedula.Mask = "000-0000000-0"; }
            if (MTBCedula.Text.Length < 13)
            {
                MTBCedula.StateCommon.Border.Color1 = Color.Red;
                MTBCedula.StateCommon.Border.Color2 = Color.Red;
                MTBCedula.Tag = "Invalid";
            }
            else
            {
                MTBCedula.StateCommon.Border.Color1 = Color.White;
                MTBCedula.StateCommon.Border.Color2 = Color.White;
                MTBCedula.Tag = "Valid";
            }
        }
    }
}
