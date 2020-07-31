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
    class Controlador_Mesa
    {
        Vista_Mesa vista_Mesa;
        VO_MesaDirectiva vo_Mesa;
        VO_Localidad vo_Localidad;
        private ICrud InstanciaMesa = Construye_Objeto.intancias(10);
        private ICrud InstanciaLocalidad = Construye_Objeto.intancias(11);
        Validaciones valida;
        TypeAssistant assistant;
        Boolean checador = false;

        public Controlador_Mesa(Vista_Mesa vista_Mesa, VO_MesaDirectiva vo_Mesa)
        {
            this.vista_Mesa = vista_Mesa;
            this.vo_Mesa = vo_Mesa;
            valida = new Validaciones();
            cargaInicialCombos();
            Eventos_Botones();
            llenaGrid();
            vista_Mesa.dtgMesa.DataBindingComplete += Limpiar;
            assistant = new TypeAssistant();
            assistant.Idled += Temporizador;
        }

     

        private void Eventos_Botones()
        {
            vista_Mesa.btnGuardar.Click += Click_Guardar;
            vista_Mesa.btnEditar.Click += Click_Modificar;
            vista_Mesa.btnEliminar.Click += Click_Eliminar;
            vista_Mesa.btnLimpiar.Click += Click_Limpiar;
            vista_Mesa.dtgMesa.CellClick += Click_Fila;            
            vista_Mesa.txtLocalidad.TextChanged += Cambio;
        }     

        private void Click_Fila(object sender, DataGridViewCellEventArgs e)
        {
            vista_Mesa.erpAviso.Clear();
            vista_Mesa.btnGuardar.Enabled = false;
            int Status = int.Parse(vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[2].Value.ToString());            
            vo_Mesa.idStatus = Status;
            vo_Mesa.idMesa = int.Parse(vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[0].Value.ToString());
            vo_Mesa.idDireccion = int.Parse(vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[4].Value.ToString());
            vo_Mesa.idLocalidad = int.Parse(vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[7].Value.ToString());
            vista_Mesa.txtNombre.Text = vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[1].Value.ToString();
            vista_Mesa.cmbStatus.SelectedIndex = (Status == 1) ? 1 : 2;            
            vista_Mesa.txtCalle.Text= vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[5].Value.ToString();
            vista_Mesa.txtNumero.Text= vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[6].Value.ToString();
            vista_Mesa.txtLocalidad.Text= vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[7].Value.ToString();
            vista_Mesa.txtMunicipio.Text = vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[8].Value.ToString();
            vista_Mesa.txtEstado.Text = vista_Mesa.dtgMesa.Rows[vista_Mesa.dtgMesa.CurrentRow.Index].Cells[9].Value.ToString();
        }

        #region Metodos Guardar, Modificar, Eliminar y Listar  
        //Metodo implementado para el almacenamiento de la informacion en la Bds
        private void Click_Guardar(object sender, EventArgs e)
        {
            if (valida.Vacios(vista_Mesa, vista_Mesa.erpAviso))
            {
                vo_Mesa.Nombre = vista_Mesa.txtNombre.Text;
                vo_Mesa.idStatus =int.Parse(vista_Mesa.cmbStatus.SelectedIndex.ToString());
                vo_Mesa.idLocalidad =int.Parse(vista_Mesa.txtLocalidad.Text);
                vo_Mesa.Calle = vista_Mesa.txtCalle.Text;
                vo_Mesa.Numero = vista_Mesa.txtNumero.Text;
                if (InstanciaMesa.Insertar(vo_Mesa))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_Mesa = new VO_MesaDirectiva();
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
            vista_Mesa.erpAviso.Clear();
            if (valida.revisaContenidoGrid(vista_Mesa.dtgMesa))
            {
                if (valida.revisaSeleccionado(vista_Mesa.dtgMesa))
                {
                    vo_Mesa.Nombre = vista_Mesa.txtNombre.Text;
                    vo_Mesa.idStatus =int.Parse( vista_Mesa.cmbStatus.SelectedIndex.ToString());                    
                    vo_Mesa.Calle = vista_Mesa.txtCalle.Text;
                    vo_Mesa.Numero = vista_Mesa.txtNumero.Text;
      
                    if (InstanciaMesa.Modificar(vo_Mesa))
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
            vista_Mesa.erpAviso.Clear();            
            if (valida.revisaContenidoGrid(vista_Mesa.dtgMesa))
            {
                if (valida.revisaSeleccionado(vista_Mesa.dtgMesa))
                {
                    if (InstanciaMesa.Eliminar(vo_Mesa))
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

        //Metodo implementado para limpiar los controles de la ventana
        private void Click_Limpiar(object sender, EventArgs e)
        {
            refrescar();
        }
        #endregion


        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vista_Mesa.dtgMesa.ClearSelection();
        }

        private void llenaGrid()
        {            
            List<object> lstMesas = InstanciaMesa.Listar(null);
            if (lstMesas.Count != 0)
            {
                vista_Mesa.dtgMesa.DataSource = lstMesas;
                for (int fila = 0; fila < lstMesas.Count; fila++)
                {
                    int valor = int.Parse(vista_Mesa.dtgMesa[2, fila].Value.ToString());                  
                    vista_Mesa.dtgMesa[3, fila].Value = (valor == 2) ? "Inactivo" : "Activo";
                }
                vista_Mesa.dtgMesa.Columns[0].Visible = false;
                vista_Mesa.dtgMesa.Columns[2].Visible = false;
                vista_Mesa.dtgMesa.Columns[4].Visible = false;
                vista_Mesa.dtgMesa.Columns[5].Visible = false;
                vista_Mesa.dtgMesa.Columns[6].Visible = false;
                vista_Mesa.dtgMesa.Columns[7].Visible = false;
            }
            else
            {
                vista_Mesa.dtgMesa.DataSource = "";
            }
        }

        private void refrescar()
        {            
            vista_Mesa.btnGuardar.Enabled = true;
            vista_Mesa.txtNombre.Clear();
            vista_Mesa.txtLocalidad.Clear();
            vista_Mesa.txtMunicipio.Clear();
            vista_Mesa.txtEstado.Clear();
            vista_Mesa.txtCalle.Clear();
            vista_Mesa.txtNumero.Clear();
            vista_Mesa.cmbStatus.SelectedIndex = 0;
        }


        private void cargaInicialCombos()
        {            
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("-1", "Elije");
            test.Add("1", "Activo");
            test.Add("0", "Inactivo");
            vista_Mesa.cmbStatus.DataSource = new BindingSource(test, null);
            vista_Mesa.cmbStatus.DisplayMember = "Value";
            vista_Mesa.cmbStatus.ValueMember = "Key";            
        }


        private void Cambio(object sender, EventArgs e)
        {
            assistant.TextChanged();
        }

        private void Temporizador(object sender, EventArgs e)
        {
            vista_Mesa.Invoke(
           new MethodInvoker(() =>
           {
               if (!checador)
               {
                   Buscar();
                   return;
               }
               checador = true;

           }));
        }

        private void Buscar()
        {
            if (!checador)
            {
                vo_Localidad = new VO_Localidad();
                if (vista_Mesa.txtLocalidad.Text == "")
                {
                    MessageBox.Show("Ingrese localidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    vo_Localidad.idLocalidad = int.Parse(vista_Mesa.txtLocalidad.Text);
                    List<object> lstlocalidad = InstanciaLocalidad.Listar(vo_Localidad);
                    if ((Boolean)lstlocalidad[0])
                    {
                        vo_Localidad = (VO_Localidad)lstlocalidad[1];
                        vista_Mesa.txtMunicipio.Text = vo_Localidad.Municpio;
                        vista_Mesa.txtEstado.Text = vo_Localidad.Estado;
                    }
                    else
                    {
                        MessageBox.Show("Localidad no localizada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        vista_Mesa.txtLocalidad.Clear();
                        checador = false;
                    }
                }
            }

            checador = false;
           
        }
    }
}
