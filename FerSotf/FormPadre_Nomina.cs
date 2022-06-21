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
namespace FerSotf
{
    public partial class FormPadre_Nomina : KryptonForm
    {
        public C_Usuario CEmp { get; private set; }
        public FormPadre_Nomina(C_Usuario Emp)
        {
            CEmp = Emp;
            InitializeComponent();
        }
        KryptonForm Actual=null;
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

        private void FormPadre_Nomina_Load(object sender, EventArgs e)
        {

        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrom(new FerSotf.Forms_Nom.Form_Dep());
        }

        private void FormPadre_Nomina_Resize(object sender, EventArgs e)
        {
            if (Actual != null) { Actual.Size = kryptonPanel2.Size; }
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrom(new FerSotf.Forms_Nom.Form_Nom());
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrom(new FerSotf.Forms_Nom.Form_Emp());
        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrom(new FerSotf.Forms_Nom.Form_J());
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrom(new FerSotf.Forms_Nom.FormUsuarios());
        }
    }
}
