using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiVot_Modelo;
using DigiVot_Vista;
namespace DigiVot_Controlador
{
    class Controlador_Casilla
    {
        Vista_Casillas vista_Casilla;
        VO_Casilla vo_Casilla;
        VO_Localidad vo_Localidad;
        private ICrud InstanciaLocalidad = Construye_Objeto.intancias(11);
        private ICrud InstanciaCasillas = Construye_Objeto.intancias(12);
        Validaciones valida;
        TypeAssistant assistant;
        Boolean checador=false;

        public Controlador_Casilla(Vista_Casillas vista_Casilla, VO_Casilla vo_Casilla)
        {
            this.vista_Casilla = vista_Casilla;
            this.vo_Casilla = vo_Casilla;
            valida=new Validaciones();
            Eventos_Botones();
            llenaGrid();
            vista_Casilla.dtgCasilla.DataBindingComplete += Limpiar;
            assistant = new TypeAssistant();
            assistant.Idled += Temporizador;

        }
     
        //Metodo que se encarga de escuchar los eventos de botones
        private void Eventos_Botones()
        {
            vista_Casilla.btnGuardar.Click += Click_Guardar;
            vista_Casilla.btnEditar.Click += Click_Modificar;
            vista_Casilla.btnEliminar.Click += Click_Eliminar;
            vista_Casilla.btnLimpiar.Click += Click_Limpiar;
            vista_Casilla.dtgCasilla.CellClick += Click_Fila;
            vista_Casilla.txtClaveMesa.TextChanged += Cambio;
        }       

        #region Metodos Guardar, Modificar, Eliminar y Listar  
        //Metodo implementado para el almacenamiento de la informacion en la Bds
        private void Click_Guardar(object sender, EventArgs e)
        {
            if (vista_Casilla.txtNombre.Text == "" || vista_Casilla.txtIp.Text=="" || vista_Casilla.txtClaveMesa.Text=="")
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Casilla.Nombre = vista_Casilla.txtNombre.Text;
                vo_Casilla.Ip = vista_Casilla.txtIp.Text;
                vo_Casilla.idMesa = int.Parse(vista_Casilla.txtClaveMesa.Text);                
                if (InstanciaCasillas.Insertar(vo_Casilla))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_Casilla = new VO_Casilla();
                }
                else
                {
                    MessageBox.Show("Intente nuevamente....");
                }
            }
        }

        //Metodo implementado para la modifiacion de la informacion en la Bds
        private void Click_Modificar(object sender, EventArgs e)
        {
            if (valida.revisaContenidoGrid(vista_Casilla.dtgCasilla))
            {
                if (valida.revisaSeleccionado(vista_Casilla.dtgCasilla))
                {
                    vo_Casilla.Nombre = vista_Casilla.txtNombre.Text;
                    vo_Casilla.Ip = vista_Casilla.txtIp.Text;
                    vo_Casilla.idMesa = int.Parse(vista_Casilla.txtClaveMesa.Text);
                    if (InstanciaCasillas.Modificar(vo_Casilla))
                    {
                        llenaGrid();
                        refrescar();
                        MessageBox.Show("Modificado correctamente....");
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }

                }
            }
        }

        //Metodo implementado para eliminacion de la informacion en la Bds
        private void Click_Eliminar(object sender, EventArgs e)
        {
            if (valida.revisaContenidoGrid(vista_Casilla.dtgCasilla))
            {
                if (valida.revisaSeleccionado(vista_Casilla.dtgCasilla))
                {
                    if (InstanciaCasillas.Eliminar(vo_Casilla))
                    {
                        llenaGrid();
                        refrescar();
                        MessageBox.Show("Eliminado correctamente....");
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }
                }
            }

        }

        #endregion


        #region Herramientas de los controles de la venta

        //Metodo implementado para limpiar los controles de la ventana
        private void Click_Limpiar(object sender, EventArgs e)
        {
            refrescar();
        }        

      //Metodo para cargar el datagridview con los datos de la casilla
        private void llenaGrid()
        {
            List<object> lstMesas = InstanciaCasillas.Listar(null);
            if (lstMesas.Count != 0)
            {
                vista_Casilla.dtgCasilla.DataSource = lstMesas;
                vista_Casilla.dtgCasilla.Columns[0].Visible = false;
                vista_Casilla.dtgCasilla.Columns[3].Visible = false;               
            }
            else
            {
                vista_Casilla.dtgCasilla.DataSource = "";
            }
        }

        //Metodo para refresacar los controles
        private void refrescar()
        {
            checador = true;
            vista_Casilla.txtNombre.Clear();
            vista_Casilla.txtIp.Clear();
            vista_Casilla.txtClaveMesa.Clear();            
            vista_Casilla.txtMesa.Clear();
            vista_Casilla.txtLocalidad.Clear();
            vista_Casilla.txtMunicipio.Clear();
            vista_Casilla.txtEstado.Clear();
            vo_Casilla = new VO_Casilla();
            
        }

        //Metodo que limpia los campos de la direccion
        private void reiniciaDireccion()
        {
            vista_Casilla.txtClaveMesa.Clear();
            vista_Casilla.txtMesa.Clear();
            vista_Casilla.txtLocalidad.Clear();
            vista_Casilla.txtMunicipio.Clear();
            vista_Casilla.txtEstado.Clear();
            vista_Casilla.txtClaveMesa.Focus();
        }

        //Metodo que se desencadena tras dar click sobre una fila del datagridview
        private void Click_Fila(object sender, DataGridViewCellEventArgs e)
        {
            vo_Casilla.idCasilla = int.Parse(vista_Casilla.dtgCasilla.Rows[vista_Casilla.dtgCasilla.CurrentRow.Index].Cells[0].Value.ToString());
            vista_Casilla.txtNombre.Text = vista_Casilla.dtgCasilla.Rows[vista_Casilla.dtgCasilla.CurrentRow.Index].Cells[1].Value.ToString();
            vista_Casilla.txtIp.Text = vista_Casilla.dtgCasilla.Rows[vista_Casilla.dtgCasilla.CurrentRow.Index].Cells[2].Value.ToString();
            vista_Casilla.txtClaveMesa.Text = vista_Casilla.dtgCasilla.Rows[vista_Casilla.dtgCasilla.CurrentRow.Index].Cells[3].Value.ToString();

        }       

        //Metodo que busca en la bds la direccion a partir del idMesa
        void Buscar()
        {
            vo_Localidad = new VO_Localidad();
            if (vista_Casilla.txtClaveMesa.Text == "")
            {
                MessageBox.Show("Ingrese clave de la Mesa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Localidad.idMesa = int.Parse(vista_Casilla.txtClaveMesa.Text);
                List<object> lstlocalidad = InstanciaLocalidad.Listar(vo_Localidad);
                if ((Boolean)lstlocalidad[0])
                {
                    vo_Localidad = (VO_Localidad)lstlocalidad[1];
                    vista_Casilla.txtMesa.Text = vo_Localidad.Mesa;
                    vista_Casilla.txtLocalidad.Text = vo_Localidad.Localidad;
                    vista_Casilla.txtMunicipio.Text = vo_Localidad.Municpio;
                    vista_Casilla.txtEstado.Text = vo_Localidad.Estado;
                }
                else
                {
                    MessageBox.Show("Localidad no localizada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reiniciaDireccion();
                }
            }
        }


        //Metodo que se genera tras modificar texto del txtIdMesa, dentro de este metodo se instancia una clase que permite controlar el tiempo de textchanged
        private void Cambio(object sender, EventArgs e)
        {
            assistant.TextChanged();
        }

        //Se dispara como temporizador
        void Temporizador(object sender, EventArgs e)
        {
            vista_Casilla.Invoke(
            new MethodInvoker(() =>
            {
                if (!checador)
                {
                    Buscar();
                }
                checador = false;

            }));
        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vista_Casilla.dtgCasilla.ClearSelection();
        }
        #endregion
    }
}
