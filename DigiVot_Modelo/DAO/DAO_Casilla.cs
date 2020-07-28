using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Casilla:ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Casilla Casilla;
        
        public DAO_Casilla()
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
            Casilla = (VO_Casilla)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_Casilla";
                cmdComando.Parameters.AddWithValue("@IpAddress", Casilla.Ip);
                cmdComando.Parameters.AddWithValue("@Nombre", Casilla.Nombre);
                cmdComando.Parameters.AddWithValue("@Mesa", Casilla.idMesa);
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
            Casilla = (VO_Casilla)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modifica_Casilla";
                cmdComando.Parameters.AddWithValue("@idCasilla", Casilla.idCasilla);
                cmdComando.Parameters.AddWithValue("@IpAddress", Casilla.Ip);
                cmdComando.Parameters.AddWithValue("@Nombre", Casilla.Nombre);
                cmdComando.Parameters.AddWithValue("@Mesa", Casilla.idMesa);
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
            Casilla = (VO_Casilla)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Elimina_Casilla";
                cmdComando.Parameters.AddWithValue("@idCasilla", Casilla.idCasilla);
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
                cmdComando.CommandText = "sp_Listar_Casilla";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstCasillas = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    Casilla = new VO_Casilla();
                    Casilla.idCasilla = int.Parse(Dtt.Rows[i][0].ToString());
                    Casilla.Nombre = Dtt.Rows[i][1].ToString();
                    Casilla.Ip = Dtt.Rows[i][2].ToString();
                    Casilla.idMesa = int.Parse(Dtt.Rows[i][3].ToString());
                    lstCasillas.Add(Casilla);
                }
                return lstCasillas;
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
