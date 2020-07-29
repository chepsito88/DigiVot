using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Vista;
using DigiVot_Modelo;
using System.Windows.Forms;

namespace DigiVot_Controlador
{
    class Controlador_Password
    {
        Vista_Password vista_Password;
        VO_User vo_User;
        private ICrud InstanciaUsuarios = Construye_Objeto.intancias(4);

        public Controlador_Password(Vista_Password vista_Password, VO_User vo_User)
        {
            this.vista_Password = vista_Password;
            this.vo_User = vo_User;
            Evento_Botones();
        }

        private void Evento_Botones()
        {
            vista_Password.btnActualizar.Click += Clic_Actualizar;
        }

        private void Clic_Actualizar(object sender, EventArgs e)
        {
            if (vista_Password.txtContra.Text != "" && vista_Password.txtPass.Text !="")
            {
                if (vista_Password.txtContra.Text == vista_Password.txtPass.Text)
                {
                    vo_User.password = vista_Password.txtPass.Text;
                    if (InstanciaUsuarios.Modificar(vo_User))
                    {
                        MessageBox.Show("Modificado correctamente....");
                        Vista_Login vLogin = new Vista_Login();
                        Controlador_Login conLogin = new Controlador_Login(vLogin);
                        vLogin.StartPosition = FormStartPosition.CenterScreen;
                        vLogin.Show();
                        vista_Password.Close();
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }
                }
                else
                {
                    MessageBox.Show("Las Contraseñas no son iguales");
                }
            }
            else {
                MessageBox.Show("Campos Requeridos");
            }
            
        }
    }
}
