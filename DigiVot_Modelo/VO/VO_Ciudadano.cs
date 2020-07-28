using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public class VO_Ciudadano
    {
        public string Curp { get; set; }//0
        public string Nombre { get; set; }//1
        public string APaterno { get; set; }//2
        public string AMaterno { get; set; }//3
        public string Edad { get; set; }//4
        public string Sexo { get; set; }//5
        public string  Vigencia { get; set; }//6
        public string Folio { get; set; }//7
        public int idDireccion { get; set; }//8
        public string Calle { get; set; }//9
        public string Numero { get; set; }//10
        public int idLocalidad { get; set; }//11
        public string Municipio { get; set; }//12
        public string Estado { get; set; }//13

    }
}
