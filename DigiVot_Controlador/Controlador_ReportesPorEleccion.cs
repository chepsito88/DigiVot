using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DigiVot_Vista;

namespace DigiVot_Controlador
{
    class Controlador_ReportesPorEleccion
    {
        Vista_ReporteNacional VReportesPorEleccion = new Vista_ReporteNacional();
        public Controlador_ReportesPorEleccion(Vista_ReporteNacional vReportesPorEleccion)
        {
            this.VReportesPorEleccion = vReportesPorEleccion;
            Iniciar();
        }
        private void Iniciar()
        {
            
        }
        
    }
}
