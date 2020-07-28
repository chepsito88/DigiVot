using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Mesa:ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_MesaDirectiva Mesa;

        public DAO_Mesa()
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


        public bool Insertar(object VO)
        {
            Mesa = (VO_MesaDirectiva)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_MesaDirectiva";
                cmdComando.Parameters.AddWithValue("@Nombre", Mesa.Nombre);
                cmdComando.Parameters.AddWithValue("@Activo",Mesa.idStatus);
                cmdComando.Parameters.AddWithValue("@Calle", Mesa.Calle);
                cmdComando.Parameters.AddWithValue("@Numero", Mesa.Numero);
                cmdComando.Parameters.AddWithValue("@Localidad", Mesa.idLocalidad);
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
            Mesa = (VO_MesaDirectiva)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modificar_Mesa";
                cmdComando.Parameters.AddWithValue("@idMesa", Mesa.idMesa);
                cmdComando.Parameters.AddWithValue("@Mesa", Mesa.Nombre);
                cmdComando.Parameters.AddWithValue("@Activo", Mesa.idStatus);
                cmdComando.Parameters.AddWithValue("@idDireccion", Mesa.idDireccion);
                cmdComando.Parameters.AddWithValue("@Calle", Mesa.Calle);
                cmdComando.Parameters.AddWithValue("@Numero", Mesa.Numero);
                cmdComando.Parameters.AddWithValue("@idLocalidad", Mesa.idLocalidad);
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
            Mesa = (VO_MesaDirectiva)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Elimina_Mesa";
                cmdComando.Parameters.AddWithValue("@idDireccion", Mesa.idDireccion);
                cmdComando.Parameters.AddWithValue("@idMesa", Mesa.idMesa);
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
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                cmdComando.CommandText = "sp_Listar_Mesa";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstMesa = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    Mesa = new VO_MesaDirectiva();
                    Mesa.idMesa = int.Parse(Dtt.Rows[i][0].ToString());
                    Mesa.Nombre = Dtt.Rows[i][1].ToString();
                    Mesa.idStatus =int.Parse(Dtt.Rows[i][2].ToString());
                    Mesa.idDireccion =int.Parse(Dtt.Rows[i][3].ToString());
                    Mesa.Calle = Dtt.Rows[i][4].ToString();
                    Mesa.Numero = Dtt.Rows[i][5].ToString();
                    Mesa.idLocalidad =int.Parse(Dtt.Rows[i][6].ToString());                    
                    Mesa.Municipio = Dtt.Rows[i][7].ToString();
                    Mesa.Estado = Dtt.Rows[i][8].ToString();
                    lstMesa.Add(Mesa);
                }
                return lstMesa;
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
