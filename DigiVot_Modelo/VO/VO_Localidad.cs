using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public class VO_Localidad
    {
        public int idLocalidad { get; set; }
        public string Localidad { get; set; }
        public string Municpio { get; set; }
        public string Estado { get; set; }
        public int idMesa { get; set; }
        public string  Mesa { get; set; }
    }
}
