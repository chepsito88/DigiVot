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
        public int idUser { get; set; }
        public string Puesto { get; set; }
        public string Curp { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Reglas { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public byte[] datos { get; set; }
        public PictureBox picture { get; set; }
    }
}
