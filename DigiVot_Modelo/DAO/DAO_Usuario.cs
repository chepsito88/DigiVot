using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Modelo
{
    class DAO_Usuario
    {
       
        public string  Default (string Email)
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudPassword = 8;
            string password = string.Empty;
            for (int i = 0; i < longitudPassword; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                password += letra.ToString();
            }            
            return encriptar(password, Email);
        }


        public string encriptar(string str,string Email)
        {
            notificacion(str, Email);
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            
            return sb.ToString();
        }


        public string encriptar2(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public void notificacion(string str,string Email)
        {
            MailMessage message = new MailMessage();
            message.To.Add(Email);
            message.Subject = "Contraseña";
            message.SubjectEncoding = Encoding.UTF8;

            message.Body = "Contraseña Generada: "+str;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            message.From = new MailAddress("fugus.dks@gmail.com");

            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("fugus.dks@gmail.com", "NIGMA@2019");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(message);
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas con el envio de su contraseña");
            }
        }
    }
}
