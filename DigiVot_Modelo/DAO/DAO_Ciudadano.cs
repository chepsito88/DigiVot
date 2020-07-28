using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Ciudadano : ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Ciudadano vo_Ciudadano;

        public DAO_Ciudadano()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
        }

        private void Encabezado()
        {
            cmdComando = new SqlCommand();
            cmdComando.Connection = cnnConexion.Conexion;
            cnnConexion.Abrir();
            cmdComando.CommandType = CommandType.StoredProcedure;
        }
        public bool Eliminar(object VO)
        {
            vo_Ciudadano = (VO_Ciudadano)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Elimina_Ciudadano";
                cmdComando.Parameters.AddWithValue("@idDireccion", vo_Ciudadano.idDireccion);
                cmdComando.Parameters.AddWithValue("@Curp", vo_Ciudadano.Curp);
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

        public bool Insertar(object VO)
        {
            vo_Ciudadano = (VO_Ciudadano)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_Ciudadano";
                cmdComando.Parameters.AddWithValue("@Curp", vo_Ciudadano.Curp);
                cmdComando.Parameters.AddWithValue("@Nombre", vo_Ciudadano.Nombre);
                cmdComando.Parameters.AddWithValue("@aPaterno", vo_Ciudadano.APaterno);
                cmdComando.Parameters.AddWithValue("@aMaterno", vo_Ciudadano.AMaterno);
                cmdComando.Parameters.AddWithValue("@Edad", vo_Ciudadano.Edad);
                cmdComando.Parameters.AddWithValue("@Sexo", vo_Ciudadano.Sexo);
                cmdComando.Parameters.AddWithValue("@Vigencia", vo_Ciudadano.Vigencia);
                cmdComando.Parameters.AddWithValue("@Folio", vo_Ciudadano.Folio);
                cmdComando.Parameters.AddWithValue("@Calle", vo_Ciudadano.Calle);
                cmdComando.Parameters.AddWithValue("@Numero", vo_Ciudadano.Numero);
                cmdComando.Parameters.AddWithValue("@Localidad", vo_Ciudadano.idLocalidad);
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
                vo_Ciudadano = (VO_Ciudadano)VO;
                cmdComando.CommandText = "sp_Listar_Ciudadano";
                if (vo_Ciudadano!=null)
                {
                    cmdComando.Parameters.AddWithValue("@Curp", vo_Ciudadano.Curp);
                    verifica = true;
                }                
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstCiudadanos = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    vo_Ciudadano = new VO_Ciudadano();
                    vo_Ciudadano.Curp = Dtt.Rows[i][0].ToString();
                    vo_Ciudadano.Nombre = Dtt.Rows[i][1].ToString();
                    vo_Ciudadano.APaterno = Dtt.Rows[i][2].ToString();
                    vo_Ciudadano.AMaterno = Dtt.Rows[i][3].ToString();
                    vo_Ciudadano.Edad = Dtt.Rows[i][4].ToString();
                    vo_Ciudadano.Sexo = Dtt.Rows[i][5].ToString();
                    vo_Ciudadano.Vigencia = Dtt.Rows[i][6].ToString();
                    vo_Ciudadano.Folio = Dtt.Rows[i][7].ToString();
                    vo_Ciudadano.idDireccion = int.Parse(Dtt.Rows[i][8].ToString());
                    if (verifica!=true)
                    {
                        vo_Ciudadano.Calle = Dtt.Rows[i][9].ToString();
                        vo_Ciudadano.Numero = Dtt.Rows[i][10].ToString();
                        vo_Ciudadano.idLocalidad = int.Parse(Dtt.Rows[i][11].ToString());
                    }
                                                    
                    lstCiudadanos.Add(vo_Ciudadano);
                }
                return lstCiudadanos;
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

        public bool Modificar(object VO)
        {
            vo_Ciudadano = (VO_Ciudadano)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modifica_Ciudadano";
                cmdComando.Parameters.AddWithValue("@Curp", vo_Ciudadano.Curp);
                cmdComando.Parameters.AddWithValue("@Nombre", vo_Ciudadano.Nombre);
                cmdComando.Parameters.AddWithValue("@aPaterno", vo_Ciudadano.APaterno);
                cmdComando.Parameters.AddWithValue("@aMaterno", vo_Ciudadano.AMaterno);
                cmdComando.Parameters.AddWithValue("@Edad", vo_Ciudadano.Edad);
                cmdComando.Parameters.AddWithValue("@Sexo", vo_Ciudadano.Sexo);
                cmdComando.Parameters.AddWithValue("@Vigencia", vo_Ciudadano.Vigencia);
                cmdComando.Parameters.AddWithValue("@Folio", vo_Ciudadano.Folio);
                cmdComando.Parameters.AddWithValue("@Calle", vo_Ciudadano.Calle);
                cmdComando.Parameters.AddWithValue("@Numero", vo_Ciudadano.Numero);
                cmdComando.Parameters.AddWithValue("@Localidad", vo_Ciudadano.idLocalidad);
                cmdComando.Parameters.AddWithValue("@idDireccion", vo_Ciudadano.idDireccion);
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
    }
}
