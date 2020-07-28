using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public class VO_MesaDirectiva
    {
        public int idMesa { get; set; }
        public string Nombre { get; set; }
        public int idStatus { get; set; }
        public string Status { get; set; }
        public int idDireccion { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public int idLocalidad { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
    }
}
