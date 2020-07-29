using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Vista
{
    public partial class Vista_Reportes : Form
    {
        public Vista_Reportes()
        {
            InitializeComponent();
        }

        private void Vista_Reportes_Load(object sender, EventArgs e)
        {

            this.rptELecciones.RefreshReport();
        }
    }
}
