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
    public partial class Form_Login : KryptonForm
    {
        public Form_Login()
        {
            InitializeComponent();
            logged = false;
        }
        public C_Usuario emp{ get; private set; }
        private void Form_Login_Load(object sender, EventArgs e)
        {
         if (! ClasesF.ConnectionDB.TestCon())
            {
                MessageBox.Show("No se pudo conectar a el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            //LoginS("1", "2507");
        }
        public bool logged { get; private set; }
        private void Button_Log_Click(object sender, EventArgs e)
        {
            LoginS(BoxUser.Text, BoxPassword.Text);
        }
        private void LoginS(string s,string e)
        {
            emp = new C_Usuario().Log_in(s,e);
            logged = emp != null ? true : false;
            if (logged) this.Close(); else
            { MessageBox.Show("Ha ingresado sus datos incorrectamente", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);}
        }
        private void BoxUser_Enter(object sender, EventArgs e)
        {
            BoxUser.StateCommon.Border.Color1 = Color.Red;
            if (BoxUser.Text == "User")
                BoxUser.Text = "";
           
        }

        private void BoxUser_Leave(object sender, EventArgs e)
        {
            if (BoxUser.Text == "") { BoxUser.Text = "User"; }
          else  BoxUser.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);    
        }

        private void BoxPassword_Leave(object sender, EventArgs e)
        {
            if (BoxPassword.Text == "") { BoxPassword.Text = "Contraseña"; BoxPassword.UseSystemPasswordChar = false; BoxPassword.PasswordChar = BoxUser.PasswordChar; }
            else BoxPassword.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 244);
                }

        private void BoxPassword_Enter(object sender, EventArgs e)
        {
            BoxPassword.StateCommon.Border.Color1 = Color.Red;
            if (BoxPassword.Text=="Contraseña")
            BoxPassword.Text = "";

            BoxPassword.UseSystemPasswordChar = true;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            LoginS("1", "2507");
        }

        private void BoxUser_TextChanged(object sender, EventArgs e)
        {
            if (BoxUser.Text.Contains('-'))// & BoxUser.Text != "   -       -")
            {
                string s = BoxUser.Text;
                BoxUser.Mask = "000-0000000-0";
                BoxUser.Text = s;
            }
            else if (BoxUser.Mask != "")
            {
                BoxUser.Mask = String.Empty;
            }
            
            Button_Log.Enabled = (BoxUser.Text == string.Empty || BoxUser.Text == "User") || (BoxPassword.Text == string.Empty || BoxPassword.Text == "Contraseña") ? false : true;
        }

        private void BoxPassword_TextChanged(object sender, EventArgs e)
        {
            Button_Log.Enabled = (BoxUser.Text == string.Empty || BoxUser.Text == "User" ) || (BoxPassword.Text == string.Empty || BoxPassword.Text == "Contraseña") ? false : true;

        }

        private void BoxUser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
