using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Modelo;
using DigiVot_Vista;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DigiVot_Controlador
{
    class Controlador_Reportes
    {
        private VO_Reportes vo_Reportes;
        private Vista_Reportes vista_Reportes;
        private string Reporte;
        private string Dataset;
        List<object> lstVotaciones;


        public Controlador_Reportes(Vista_Reportes vista_Reportes, VO_Reportes vo_Reportes, string Reporte, string Dataset, List<object>lstVotaciones)
        {
            this.vo_Reportes = vo_Reportes;
            this.vista_Reportes = vista_Reportes;
            this.Reporte = Reporte;
            this.Dataset = Dataset;
            this.lstVotaciones = lstVotaciones;
            iniciar();
        }

        private void iniciar()
        {
            vista_Reportes.rptELecciones.ProcessingMode = ProcessingMode.Local;
            vista_Reportes.rptELecciones.LocalReport.ReportPath = "..\\..\\..\\DigiVot_Vista\\Reportes\\" + Reporte + ".rdlc";
            ReportDataSource datos = new ReportDataSource();
            datos.Name = Dataset;
            datos.Value = lstVotaciones;
            vista_Reportes.rptELecciones.RefreshReport();
            vista_Reportes.rptELecciones.LocalReport.DataSources.Clear();
            vista_Reportes.rptELecciones.LocalReport.DataSources.Add(datos);
            vista_Reportes.rptELecciones.RefreshReport();
        }
    }
}
