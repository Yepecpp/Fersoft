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
using ClasesF;

namespace FerSotf.Forms_In
{
    public partial class Form_Inventario : KryptonForm
    {
        public Form_Inventario()
        {
            InitializeComponent();
        }
        List<int> names = new List<int>();
        private void Form_Inventario_Load(object sender, EventArgs e)
        {
            var xy = C_Prov.CargarProv("0");
            CargarDT("0");
            for (int i = 0; i <xy.Count; i++)
            {
                names.Add(xy[i].ID);
                CB_Prov.Items.Add(xy[i].Nombre);
            }
        }

        private void Label_ID_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tb_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Ag_TextChanged(object sender, EventArgs e)
        {

        }
        private void CargarDT(string x)
        {
            if (x == "") x = "0";
            KDataGrid.DataSource = C_Prod.CargarProd(x);
        }

        private void TextBox_Select_TextChanged(object sender, EventArgs e)
        {
            CargarDT(TextBox_Select.Text);
        }
        private void CargarCB(string x)
        {
            for (int i = 0; i < names.Count; i++)
            { 
                if (CB_Prov.Items[i].ToString()== x)
                {
                    CB_Prov.SelectedItem = i;
                }
            }
        }
        private void KDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow x = KDataGrid.Rows[e.RowIndex];
            Label_ID.Text = Label_ID.Text.Substring(0, 3) + x.Cells[0].Value.ToString();
            TBNombre.Text = x.Cells[1].Value.ToString();
            TB_Marca.Text= x.Cells[2].Value.ToString();
            Tb_Precio.Text = x.Cells[3].Value.ToString();
            Tb_Categoria.Text= x.Cells[5].Value.ToString();
            CargarCB(x.Cells[4].Value.ToString());
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
             if (Tb_Precio.Text == "" && TBNombre.Text == "" && TB_Marca.Text == "" && Tb_Categoria.Text == "" &&
             CB_Prov.SelectedIndex==-1
             ){
                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             return ;}
            KDataGrid.DataSource = new C_Prod() {Prov=names[CB_Prov.SelectedIndex], Nombre=TBNombre.Text,
                Marca=TB_Marca.Text, Categoria=Tb_Categoria.Text, Precio=float.Parse(Tb_Precio.Text), Ubi="x"
            }.InsertarProd();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
        if (Tb_Precio.Text == "" || TBNombre.Text == "" && TB_Marca.Text == "" && Tb_Categoria.Text == "" &&
             CB_Prov.SelectedIndex==-1
             ){
                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
             return ;}
            if (Label_ID.Text.Length == 3) { MessageBox.Show("Falta ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            KDataGrid.DataSource = new C_Prod()
                {
                    Id=int.Parse(Label_ID.Text.Substring(3)),
                    Prov = names[CB_Prov.SelectedIndex],
                    Nombre = TBNombre.Text,
                    Marca = TB_Marca.Text,
                    Categoria = Tb_Categoria.Text,
                    Precio = float.Parse(Tb_Precio.Text),
                    Ubi = "x"
                }.UpdateProd();

            
        }
    }
}
