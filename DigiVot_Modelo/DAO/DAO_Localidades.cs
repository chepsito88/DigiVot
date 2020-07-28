using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Localidades : ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Localidad Localidad;

        public DAO_Localidades()
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
            throw new NotImplementedException();
        }

        public bool Insertar(object VO)
        {
            throw new NotImplementedException();
        }

        public List<object> Listar(object VO)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                Localidad = (VO_Localidad)VO;
                cmdComando.CommandText = "sp_Lista_Localidad";
                cmdComando.Parameters.AddWithValue("@idLocalidad", Localidad.idLocalidad);
                cmdComando.Parameters.AddWithValue("@idMesa", Localidad.idMesa);                
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                int valor = Localidad.idMesa;
                List<object> lstLocalidad = new List<object>();
                if (Dtt.Rows.Count!=0)
                {
                    Localidad = new VO_Localidad();
                    if (valor != 0)
                    {
                        Localidad.Mesa = Dtt.Rows[0][0].ToString();
                        Localidad.Localidad = Dtt.Rows[0][1].ToString();
                        Localidad.Municpio = Dtt.Rows[0][2].ToString();
                        Localidad.Estado = Dtt.Rows[0][3].ToString();
                    }
                    else {
                        Localidad.Municpio = Dtt.Rows[0][0].ToString();
                        Localidad.Estado = Dtt.Rows[0][1].ToString();
                    }
                    lstLocalidad.Add(true);
                    lstLocalidad.Add(Localidad);
                }
                else
                {
                    lstLocalidad.Add(false);
                }
                return lstLocalidad;
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
            throw new NotImplementedException();
        }
    }
}
