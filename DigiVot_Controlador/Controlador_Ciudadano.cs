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
    class Controlador_Ciudadano
    {
        Vista_Ciudadano vista_Ciudadano;
        VO_Ciudadano vo_Ciudadano;
        VO_Localidad vo_Localidad;
        private ICrud InstanciaCiudadano = Construye_Objeto.intancias(7);
        private ICrud InstanciaLocalidad = Construye_Objeto.intancias(11);
        Validaciones valida;
        TypeAssistant assistant;
        Boolean checador = false;

        public Controlador_Ciudadano(Vista_Ciudadano vista_Ciudadano, VO_Ciudadano vo_Ciudadano)
        {
            this.vista_Ciudadano = vista_Ciudadano;
            this.vo_Ciudadano = vo_Ciudadano;
            valida = new Validaciones();
            Eventos_Botones();
            llenaGrid();
            vista_Ciudadano.dtgListaCiudadanos.DataBindingComplete += Limpiar;
            assistant = new TypeAssistant();
            assistant.Idled += Temporizador;
            vista_Ciudadano.cmbSexo.SelectedIndex = 0;
        }

        //Metodo que se encarga de escuchar los eventos de botones
        private void Eventos_Botones()
        {
            vista_Ciudadano.btnGuardar.Click += Click_Guardar;
            vista_Ciudadano.btnEditar.Click += Click_Modificar;
            vista_Ciudadano.btnEliminar.Click += Click_Eliminar;
            vista_Ciudadano.btnLimpiar.Click += Click_Limpiar;
            vista_Ciudadano.dtgListaCiudadanos.CellClick += Click_Fila;
            vista_Ciudadano.txtclave.TextChanged += Cambio;

        }

        #region Metodos Guardar, Modificar, Eliminar y Listar  
        //Metodo implementado para el almacenamiento de la informacion en la Bds
        private void Click_Guardar(object sender, EventArgs e)
        {
            if (vista_Ciudadano.txtNombre.Text == "" || vista_Ciudadano.txtApellido.Text == "" || vista_Ciudadano.txtApellidoM.Text == "" || vista_Ciudadano.txtCurp.Text == "" || vista_Ciudadano.txtEdad.Text == "" || vista_Ciudadano.cmbSexo.SelectedIndex == 0 || vista_Ciudadano.txtFolioINE.Text == "" || vista_Ciudadano.txtVigencia.Text == "" || vista_Ciudadano.txtCalle.Text == "" || vista_Ciudadano.txtNumero.Text == "" || vista_Ciudadano.txtclave.Text == "")
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Ciudadano.Curp = vista_Ciudadano.txtCurp.Text;
                vo_Ciudadano.Nombre = vista_Ciudadano.txtNombre.Text;
                vo_Ciudadano.APaterno = vista_Ciudadano.txtApellido.Text;
                vo_Ciudadano.AMaterno = vista_Ciudadano.txtApellidoM.Text;                
                vo_Ciudadano.Edad = vista_Ciudadano.txtEdad.Text;
                vo_Ciudadano.Sexo=vista_Ciudadano.cmbSexo.SelectedItem.ToString();                
                vo_Ciudadano.Folio = vista_Ciudadano.txtFolioINE.Text;
                vo_Ciudadano.Vigencia = vista_Ciudadano.txtVigencia.Text;
                vo_Ciudadano.Calle = vista_Ciudadano.txtCalle.Text;
                vo_Ciudadano.Numero = vista_Ciudadano.txtNumero.Text;
                vo_Ciudadano.idLocalidad = int.Parse(vista_Ciudadano.txtclave.Text);
                if (InstanciaCiudadano.Insertar(vo_Ciudadano))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_Ciudadano = new VO_Ciudadano();
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
            if (valida.revisaContenidoGrid(vista_Ciudadano.dtgListaCiudadanos))
            {
                if (valida.revisaSeleccionado(vista_Ciudadano.dtgListaCiudadanos))
                {
                    if (vista_Ciudadano.txtNombre.Text == "" || vista_Ciudadano.txtApellido.Text == "" || vista_Ciudadano.txtApellidoM.Text == "" || vista_Ciudadano.txtCurp.Text == "" || vista_Ciudadano.txtEdad.Text == "" || vista_Ciudadano.cmbSexo.SelectedIndex == 0 || vista_Ciudadano.txtFolioINE.Text == "" || vista_Ciudadano.txtVigencia.Text == "" || vista_Ciudadano.txtCalle.Text == "" || vista_Ciudadano.txtNumero.Text == "" || vista_Ciudadano.txtclave.Text == "")
                    {
                        MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        vo_Ciudadano.Curp = vista_Ciudadano.txtCurp.Text;
                        vo_Ciudadano.Nombre = vista_Ciudadano.txtNombre.Text;
                        vo_Ciudadano.APaterno = vista_Ciudadano.txtApellido.Text;
                        vo_Ciudadano.AMaterno = vista_Ciudadano.txtApellidoM.Text;
                        vo_Ciudadano.Edad = vista_Ciudadano.txtEdad.Text;
                        vo_Ciudadano.Sexo = vista_Ciudadano.cmbSexo.SelectedItem.ToString();
                        vo_Ciudadano.Folio = vista_Ciudadano.txtFolioINE.Text;
                        vo_Ciudadano.Vigencia = vista_Ciudadano.txtVigencia.Text;
                        vo_Ciudadano.Calle = vista_Ciudadano.txtCalle.Text;
                        vo_Ciudadano.Numero = vista_Ciudadano.txtNumero.Text;
                        vo_Ciudadano.idLocalidad = int.Parse(vista_Ciudadano.txtclave.Text);
                        if (InstanciaCiudadano.Modificar(vo_Ciudadano))
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
        }

        //Metodo implementado para eliminacion de la informacion en la Bds
        private void Click_Eliminar(object sender, EventArgs e)
        {
            if (valida.revisaContenidoGrid(vista_Ciudadano.dtgListaCiudadanos))
            {
                if (valida.revisaSeleccionado(vista_Ciudadano.dtgListaCiudadanos))
                {
                    if (InstanciaCiudadano.Eliminar(vo_Ciudadano))
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
            List<object> lstMesas = InstanciaCiudadano.Listar(null);
            if (lstMesas.Count != 0)
            {
                vista_Ciudadano.dtgListaCiudadanos.DataSource = lstMesas;
                vista_Ciudadano.dtgListaCiudadanos.Columns[4].Visible = false;
                vista_Ciudadano.dtgListaCiudadanos.Columns[5].Visible = false;
                vista_Ciudadano.dtgListaCiudadanos.Columns[8].Visible = false;
                vista_Ciudadano.dtgListaCiudadanos.Columns[9].Visible = false;
                vista_Ciudadano.dtgListaCiudadanos.Columns[10].Visible = false;
                vista_Ciudadano.dtgListaCiudadanos.Columns[11].Visible = false;
                vista_Ciudadano.dtgListaCiudadanos.Columns[12].Visible = false;
                vista_Ciudadano.dtgListaCiudadanos.Columns[13].Visible = false;
            }
            else
            {
                vista_Ciudadano.dtgListaCiudadanos.DataSource = "";
            }
        }

        //Metodo para refresacar los controles
        private void refrescar()
        {
            checador = true;
            vista_Ciudadano.txtCurp.Clear();
            vista_Ciudadano.txtNombre.Clear(); ;
            vista_Ciudadano.txtApellido.Clear();
            vista_Ciudadano.txtApellidoM.Clear();
            vista_Ciudadano.txtCurp.Clear();
            vista_Ciudadano.cmbSexo.SelectedIndex = 0;
            vista_Ciudadano.txtFolioINE.Clear();
            vista_Ciudadano.txtVigencia.Clear();
            vista_Ciudadano.txtCalle.Clear();
            vista_Ciudadano.txtNumero.Clear();
            vista_Ciudadano.txtclave.Clear();
            vista_Ciudadano.txtLocalidad.Clear();
            vista_Ciudadano.txtMunicipio.Clear();
            vista_Ciudadano.txtEstado.Clear();
            vista_Ciudadano.txtCurp.Enabled = true;
            vista_Ciudadano.btnGuardar.Enabled = true;
            vista_Ciudadano.dtgListaCiudadanos.ClearSelection();
            vo_Ciudadano = new VO_Ciudadano();

        }

        //Metodo que limpia los campos de la direccion
        private void reiniciaDireccion()
        {
            vista_Ciudadano.txtLocalidad.Clear();
            vista_Ciudadano.txtMunicipio.Clear();
            vista_Ciudadano.txtEstado.Clear();
            vista_Ciudadano.txtclave.Focus();
        }

        //Metodo que se desencadena tras dar click sobre una fila del datagridview
        private void Click_Fila(object sender, DataGridViewCellEventArgs e)
        {
            vista_Ciudadano.txtCurp.Enabled = false;
            vista_Ciudadano.btnGuardar.Enabled = false;
            vista_Ciudadano.txtCurp.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[0].Value.ToString();
            vista_Ciudadano.txtNombre.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[1].Value.ToString();
            vista_Ciudadano.txtApellido.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[2].Value.ToString();
            vista_Ciudadano.txtApellidoM.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[3].Value.ToString();
            vista_Ciudadano.txtEdad.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[4].Value.ToString();
            string texto = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[5].Value.ToString().ToUpper();
            vista_Ciudadano.cmbSexo.SelectedIndex = (texto == "M") ? 1 : 2;
            vista_Ciudadano.txtVigencia.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[6].Value.ToString();
            vista_Ciudadano.txtFolioINE.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[7].Value.ToString();            
            vista_Ciudadano.txtCalle.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[9].Value.ToString();
            vista_Ciudadano.txtNumero.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[10].Value.ToString();
            vista_Ciudadano.txtclave.Text = vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[11].Value.ToString();
            vo_Ciudadano.idDireccion = int.Parse(vista_Ciudadano.dtgListaCiudadanos.Rows[vista_Ciudadano.dtgListaCiudadanos.CurrentRow.Index].Cells[8].Value.ToString());
            vo_Ciudadano.Curp = vista_Ciudadano.txtCurp.Text;
        }

        //Metodo que busca en la bds la direccion a partir del idMesa
        void Buscar()
        {
            vo_Localidad = new VO_Localidad();
            if (vista_Ciudadano.txtclave.Text == "")
            {
                MessageBox.Show("Ingrese clave de localidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Localidad.idLocalidad = int.Parse(vista_Ciudadano.txtclave.Text);
                List<object> lstlocalidad = InstanciaLocalidad.Listar(vo_Localidad);
                if ((Boolean)lstlocalidad[0])
                {
                    vo_Localidad = (VO_Localidad)lstlocalidad[1];
                    vista_Ciudadano.txtLocalidad.Text = vo_Localidad.Localidad;
                    vista_Ciudadano.txtMunicipio.Text = vo_Localidad.Municpio;
                    vista_Ciudadano.txtEstado.Text = vo_Localidad.Estado;
                }
                else
                {
                    MessageBox.Show("Localidad no localizada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    checador = false;
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
            vista_Ciudadano.Invoke(
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
            vista_Ciudadano.dtgListaCiudadanos.ClearSelection();
        }
        #endregion
    }
}
