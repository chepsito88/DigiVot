using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Modelo
{
    public class VO_User
    {
        public int idUser { get; set; } //0
        public string Puesto { get; set; }//1
        public string Curp { get; set; }//2
        public string Nombre { get; set; }//3
        public string Paterno { get; set; }//4
        public string Materno { get; set; }//5
        public string Reglas { get; set; }//6
        public string usuario { get; set; }//7
        public string password { get; set; }//8
        public string Celular { get; set; }//9
        public string Email { get; set; }//10
        public byte[] datos { get; set; }//11
        public PictureBox picture { get; set; }//12
        public int modificador { get; set; }
    }
}
