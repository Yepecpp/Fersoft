using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices;
namespace FerSotf.Forms_Nom.RepNom
{
    public partial class Nom_RP : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        DateTime fin, fout;
        public Nom_RP(DateTime finn, DateTime foutt)
        {
            fin=finn;
            fout=foutt;
            fout=foutt;
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();
        }

        private void Nom_RP_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Dispose();
        }

        private void Nom_RP_Load(object sender, EventArgs e)
        {
            reportViewer1.ShowParameterPrompts = false;
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { new ReportParameter("in", fin.ToString()), new ReportParameter("out", fout.ToString()) });
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
            
       }
    }
}
