using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerSotf
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_Login Formlog;
            FormPadre Formpadre;
            while (true)
            {
                
                Formlog = new Form_Login();
                Application.Run(Formlog);

                if (Formlog.logged)
                {
                    Formpadre = new FormPadre(Formlog.emp);
                    Application.Run(Formpadre);
                    if (Formpadre.reauth)
                    {
                        Formpadre.reauth = false;

                    }
                    else break;
                }
                else break;
                
            }
        }
    }
}
