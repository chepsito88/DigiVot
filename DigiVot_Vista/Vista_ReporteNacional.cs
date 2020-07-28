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

namespace DigiVot_Vista
{
    public partial class Vista_ReporteNacional : Form
    {

        public Vista_ReporteNacional()
        {
            InitializeComponent();
        }

        private void Vista_ReporteNacional_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

    }
}
