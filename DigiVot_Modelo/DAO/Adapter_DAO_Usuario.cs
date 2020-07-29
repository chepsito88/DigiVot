using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class Adapter_DAO_Usuario : ICrud
    {

        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        private DAO_Usuario adapter;
        Modelo_Conexion cnnConexion;
        VO_User User;

        public Adapter_DAO_Usuario()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
            adapter = new DAO_Usuario();
        }

        private void Encabezado()
        {
            cmdComando = new SqlCommand();
            cmdComando.Connection = cnnConexion.Conexion;
            cnnConexion.Abrir();
            cmdComando.CommandType = CommandType.StoredProcedure;
        }
      
        public bool Insertar(object VO)
        {
            User = (VO_User)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_Usuario";
                cmdComando.Parameters.AddWithValue("@Curp", User.Curp);
                cmdComando.Parameters.AddWithValue("@Tipo", User.idUser);                
                cmdComando.Parameters.Add("@Foto", SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
                User.picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmdComando.Parameters["@Foto"].Value = ms.GetBuffer();
                cmdComando.Parameters.AddWithValue("@User", User.usuario);
                cmdComando.Parameters.AddWithValue("@Password", adapter.Default(User.Email));
                cmdComando.Parameters.AddWithValue("@Celular", User.Celular);
                cmdComando.Parameters.AddWithValue("@Email", User.Email);
                cmdComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return false;
            }
            finally
            {
                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }      
       
        public bool Modificar(object VO)
        {
            User = (VO_User)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modificar_Usuario";
                cmdComando.Parameters.AddWithValue("@Curp", User.Curp);
                if (User.password != null)
                {
                    cmdComando.Parameters.AddWithValue("@Password",adapter.encriptar(User.password,User.Email));
                }
                else
                {
                    cmdComando.Parameters.AddWithValue("@Curp", User.Curp);
                    cmdComando.Parameters.AddWithValue("@IdUser", User.idUser);
                    if (User.picture != null)
                    {
                        cmdComando.Parameters.Add("@Foto", SqlDbType.Image);
                        MemoryStream ms = new MemoryStream();
                        User.picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        cmdComando.Parameters["@Foto"].Value = ms.GetBuffer();
                    }
                    cmdComando.Parameters.AddWithValue("@Celular", User.Celular);
                    cmdComando.Parameters.AddWithValue("@Email", User.Email);
                }              
                cmdComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return false;
            }
            finally
            {

                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }

        public bool Eliminar(object VO)
        {
            User = (VO_User)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Elimina_Usuario";
                cmdComando.Parameters.AddWithValue("@Curp", User.Curp);
                cmdComando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return false;
            }
            finally
            {

                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }

        public List<object> Listar(object VO)
        {
            Boolean verifica = false;
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                User = (VO_User)VO;
                cmdComando.CommandText = "sp_Login";
                if (User != null)
                {
                    cmdComando.Parameters.AddWithValue("@User", User.Nombre);
                    string clave = adapter.encriptar2(User.password);
                    cmdComando.Parameters.AddWithValue("@Password",clave);
                }
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstUser = new List<Object>();
                if (Dtt.Rows.Count != 0)
                {
                    lstUser.Add(true);
                    for (int i = 0; i < Dtt.Rows.Count; i++)
                    {
                        VO_User user = new VO_User();
                        user.Curp = Dtt.Rows[i][0].ToString();
                        user.Nombre = Dtt.Rows[i][1].ToString();
                        user.Paterno = Dtt.Rows[i][2].ToString();
                        user.Materno = Dtt.Rows[i][3].ToString();
                        user.Puesto = Dtt.Rows[i][4].ToString();
                        user.idUser = int.Parse(Dtt.Rows[i][5].ToString());
                        user.Reglas = Dtt.Rows[i][6].ToString();
                        user.Celular = Dtt.Rows[i][8].ToString();
                        user.Email = Dtt.Rows[i][9].ToString();
                        user.usuario = Dtt.Rows[i][10].ToString();
                        byte[] datos = new byte[0];
                        if (!(Dtt.Rows[i][7] is DBNull))
                        {
                            datos = (byte[])Dtt.Rows[i][7];
                        }
                        user.modificador = int.Parse(Dtt.Rows[i][11].ToString());
                        user.datos = datos;
                        lstUser.Add(user);
                    }
                }
                else
                {
                    lstUser.Add(false);
                }
                return lstUser;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return null;
            }
            finally
            {
                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }


    }
}
