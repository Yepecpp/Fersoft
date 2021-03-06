using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesF;
using System.Resources;
using ComponentFactory.Krypton.Toolkit;
using FerSotf.Forms_In;
using ClasesF.Clases_Nom;
namespace FerSotf
{
    public partial class FormPadre : KryptonForm
    {
        public bool reauth = false;
        public C_Usuario CEmp { get; private set; }
        public FormPadre(C_Usuario emp)
        {
            
            InitializeComponent();
            Signalpanel.MaximumSize = new Size(kryptonPanel1.Width, 5);
            normalpz = kryptonPanel1.Size;
            CEmp = emp;
            infoLabel.Text = $"{CEmp.Nombre}, ({CEmp.Puesto}) ";
            RolLabel.Text = $"{CEmp.Rol.ToString()}";
        }
        #region designform
        Size normalpz;
        private void MoveSignal(Control img,Control objs)
        {
            if (img == objs) return;
            Currnt[0] = img;
            Currnt[1] = objs;
            Signalpanel.Visible = true;
            Signalpanel.Top=objs.Bottom;
            Signalpanel.Left = img.Left;
            Signalpanel.Width=img.Width+objs.Width;
        }
        private void AdjustForm() {
            Signalpanel.MaximumSize = new Size(kryptonPanel1.Width, 5);
            if (Actual!=null) Actual.Size = kryptonPanel2.Size;
            MoveSignal(Currnt[0], Currnt[1]);
        }
        KryptonForm Actual;
        private void AbrirFrom(KryptonForm Hijo = null)
        {
            if (Hijo == null) { kryptonPanel2.Controls.Remove(Actual); Actual = null; return; }
            if (Actual != null)
            {
                Actual.Close();
                kryptonPanel2.Controls.Remove(Actual);

            }
            Actual = Hijo;
            Actual.TopLevel = false;
            Actual.Dock = DockStyle.Fill;
            kryptonPanel2.Controls.Add(Actual);
            Actual.BringToFront();
            Actual.Size = kryptonPanel2.Size;
            Actual.Show();
        }
        private void Label_Inventario_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox1 as Control,sender as Control);
            AbrirFrom(new Form_Inventario());
        }

        private void FormPadre_Resize(object sender, EventArgs e)
        {
            AdjustForm(); 
        }
        Control[] Currnt = new Control[2];
        private void Label_Cliente_Click_1(object sender, EventArgs e)
        {
            MoveSignal(pictureBox2 as Control, sender as Control);
            AbrirFrom(new Form_Clientes());
        }
        bool aydio=true;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Size sss2 = pictureBox4.Size;
            if (aydio)
            {
                
                normalpz = kryptonPanel1.Size;
                kryptonPanel1.Size = new Size(pictureBox4.Size.Width+5, kryptonPanel1.Height);
                kryptonPanel2.Size = new Size(kryptonPanel2.Width + (normalpz.Width - kryptonPanel1.Width), kryptonPanel2.Height + (normalpz.Height - kryptonPanel1.Height));
                pictureBox4.Image = Properties.Resources.FoldMenu;
                aydio=false;
                foreach (Control c in kryptonPanel1.Controls)
                {
                    if (!c.Name.Contains("pictureBox"))
                    {
                       
                        c.Visible = false;
                    }
                    else
                    {
                        c.Size = sss2;
                        c.Left = pictureBox4.Left;
                    }
                }
            }
            else 
            {
               
                kryptonPanel2.Size = new Size(kryptonPanel2.Width-normalpz.Width , kryptonPanel2.Height- normalpz.Height);
                kryptonPanel1.Size = normalpz;
               aydio = true;
               pictureBox4.Image = (Bitmap)Properties.Resources.FullMenu;
                pictureBox4.Size = sss2;
                foreach (Control c in kryptonPanel1.Controls)
                {
                    if (c.Visible == true)
                    {
                        c.Size = sss2;
                        c.Left = pictureBox4.Left;
                    }
                    else
                    {
                        c.Visible = true;
                        if (c.Name.Contains("Label_"))
                        {
                            
                            c.Left = pictureBox4.Right;
                            Console.WriteLine(c.Name + " " + c.Width + " c: " + kryptonPanel1.Width + " " + c.Left);
                        }
                      
                    }
                }
            }
            pictureBox4.Size = sss2;
        }
        private void Label_Inicio_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox5 as Control, sender as Control);
            AbrirFrom(new Form_Dashboard());
        }
        

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox6 as Control, sender as Control);
            AbrirFrom(new Form_Proveedor());
        }

        private void Label_Nomina_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox7 as Control, sender as Control);
            AbrirFrom(new FormPadre_Nomina(CEmp));
        }

        private void Label_Acerca_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox8 as Control, sender as Control);
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {
            MoveSignal(pictureBox5, Label_Inicio);
        }


        private void Label_Factura_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox9, sender as Control);
            AbrirFrom(new Form_Factura());
        }

        #endregion
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            reauth = true;
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox7 as Control, sender as Control);
            AbrirFrom(new FormPadre_Nomina(CEmp));
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox9, sender as Control);
            AbrirFrom(new Form_Factura());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox6 as Control, sender as Control);
            AbrirFrom(new Form_Proveedor());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox2 as Control, sender as Control);
            AbrirFrom(new Form_Clientes());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox1 as Control, sender as Control);
            AbrirFrom(new Form_Inventario());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MoveSignal(pictureBox5 as Control, sender as Control);
            AbrirFrom(new Form_Dashboard());
        }
    }
}
