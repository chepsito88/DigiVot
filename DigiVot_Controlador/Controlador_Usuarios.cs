using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiVot_Modelo;
using DigiVot_Vista;

namespace DigiVot_Controlador
{
    class Controlador_Usuarios
    {
        Vista_Usuarios vista_Usuarios;
        VO_User vo_User;
        VO_Ciudadano vo_Ciudadano;
        private ICrud InstanciaUsuarios = Construye_Objeto.intancias(4);
        private ICrud InstanciaCiudadanos = Construye_Objeto.intancias(7);
        private ICrud InstanciaFuncionarios = Construye_Objeto.intancias(9);
        OpenFileDialog ventanaImagen;
        Validaciones valida;
        public Controlador_Usuarios(Vista_Usuarios vista_Usuarios, VO_User vo_User,VO_Ciudadano vo_Ciudadano)
        {
            this.vista_Usuarios = vista_Usuarios;
            this.vo_User = vo_User;
            this.vo_Ciudadano = vo_Ciudadano;
            valida = new Validaciones();
            cargaInicial();
            Eventos_Botones();
            llenaGrid();
            vista_Usuarios.dtgUsuarios.DataBindingComplete += Limpiar;
        }


        //Metodo que se encarga de escuchar los eventos de botones
        private void Eventos_Botones()
        {
            vista_Usuarios.btnAgregarImagen.Click += Click_Imagen;
            vista_Usuarios.btnGuardar.Click += Click_Guardar;
            vista_Usuarios.btnEditar.Click += Click_Modificar;
            vista_Usuarios.btnEliminar.Click += Click_Eliminar;
            vista_Usuarios.btnLimpiar.Click += Click_Limpiar;
            vista_Usuarios.btnBuscar.Click += Click_Buscar;
            vista_Usuarios.dtgUsuarios.CellClick += Click_Fila;
            vista_Usuarios.cmbCargo.Click += Click_ComboCargo;
        }

        private void cargaInicial()
        {
            vista_Usuarios.cmbCargo.DataSource = null;            
            vista_Usuarios.cmbCargo.Items.Clear();
            vista_Usuarios.cmbCargo.Items.Add("Elije");
            vista_Usuarios.cmbCargo.SelectedIndex = 0;
        }

       

        private void Click_ComboCargo(object sender, EventArgs e)
        {
            cargaPuestos();
        }

        private void cargaPuestos()
        {
            vista_Usuarios.cmbCargo.ValueMember = "idFuncionario";
            vista_Usuarios.cmbCargo.DisplayMember = "Funcionario";
            List<object> lstCargos = InstanciaFuncionarios.Listar(null);
            if (lstCargos.Count != 0)
            {
                vista_Usuarios.cmbCargo.DataSource = lstCargos;
            }
            else
            {
                MessageBox.Show("Favor de agregar Partidos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Metodo empleado para abrir una imagen 
        private void Click_Imagen(object sender, EventArgs e)
        {
            ventanaImagen = new OpenFileDialog();
            DialogResult result = ventanaImagen.ShowDialog();
            ventanaImagen.Title = "Selecione el achivo adecuado";
            ventanaImagen.Filter = "Archivos (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            ventanaImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (result == DialogResult.OK)
            {
                vista_Usuarios.ptbUsuario.Load(ventanaImagen.FileName);
            }
            else if (result == DialogResult.Cancel)
            {

                MessageBox.Show("Revisar");
            }
        }


        #region Metodos Guardar, Modificar, Eliminar y Listar  
        //Metodo implementado para el almacenamiento de la informacion en la Bds
        private void Click_Guardar(object sender, EventArgs e)
        {
            if (vista_Usuarios.txtCurp.Text == "" || vista_Usuarios.txtUser.Text == "" || vista_Usuarios.txtTelefono.Text == "" || vista_Usuarios.txtEmail.Text == "" )
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_User.Curp = vista_Usuarios.txtCurp.Text;
                vo_User.idUser =int.Parse(vista_Usuarios.cmbCargo.SelectedValue.ToString());
                vo_User.picture = vista_Usuarios.ptbUsuario;
                vo_User.usuario = vista_Usuarios.txtUser.Text;
                vo_User.Celular = vista_Usuarios.txtTelefono.Text;
                vo_User.Email = vista_Usuarios.txtEmail.Text;               
                if (InstanciaUsuarios.Insertar(vo_User))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_User = new VO_User();
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
            if (valida.revisaContenidoGrid(vista_Usuarios.dtgUsuarios))
            {
                if (valida.revisaSeleccionado(vista_Usuarios.dtgUsuarios))
                {
                    if (vista_Usuarios.txtNombre.Text == "" || vista_Usuarios.txtUser.Text==""||vista_Usuarios.txtUser.Text == ""||vista_Usuarios.txtUser.Text == "")
                    {
                        MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        vo_User.Curp = vista_Usuarios.txtCurp.Text;
                        vo_User.idUser = (vista_Usuarios.cmbCargo.SelectedValue != null) ? int.Parse(vista_Usuarios.cmbCargo.SelectedValue.ToString()) : -1;
                        bool verifica = (ventanaImagen != null) ? true : false;
                        if (verifica)
                        {
                            vo_User.picture = vista_Usuarios.ptbUsuario;
                        }
                        vo_User.usuario = vista_Usuarios.txtUser.Text;
                        vo_User.Celular = vista_Usuarios.txtTelefono.Text;
                        vo_User.Email = vista_Usuarios.txtEmail.Text;
                        if (InstanciaUsuarios.Modificar(vo_User))
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
            if (valida.revisaContenidoGrid(vista_Usuarios.dtgUsuarios))
            {
                if (valida.revisaSeleccionado(vista_Usuarios.dtgUsuarios))
                {
                    vo_User.Curp = vista_Usuarios.txtCurp.Text;
                    if (InstanciaUsuarios.Eliminar(vo_User))
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
            List<object> lstUsuarios = InstanciaUsuarios.Listar(null);
            lstUsuarios.RemoveAt(0);
            if (lstUsuarios.Count != 0)
            {
                vista_Usuarios.dtgUsuarios.DataSource = lstUsuarios;
                vista_Usuarios.dtgUsuarios.Columns[0].Visible = false;
                vista_Usuarios.dtgUsuarios.Columns[1].Visible = false;
                vista_Usuarios.dtgUsuarios.Columns[2].Visible = false;
                vista_Usuarios.dtgUsuarios.Columns[6].Visible = false;
                vista_Usuarios.dtgUsuarios.Columns[8].Visible = false;
                vista_Usuarios.dtgUsuarios.Columns[11].Visible = false;
                vista_Usuarios.dtgUsuarios.Columns[12].Visible = false;
                vista_Usuarios.dtgUsuarios.Columns[13].Visible = false;
            }
            else
            {
                vista_Usuarios.dtgUsuarios.DataSource = "";
            }
        }

        //Metodo para refresacar los controles
        private void refrescar()
        {
            vista_Usuarios.txtCurp.Clear();
            vista_Usuarios.txtNombre.Clear(); ;
            vista_Usuarios.txtApellidoP.Clear();
            vista_Usuarios.txtApellidoM.Clear();            
            vista_Usuarios.txtUser.Clear();
            vista_Usuarios.txtTelefono.Clear();
            vista_Usuarios.txtEmail.Clear();
            vista_Usuarios.txtCurp.Enabled = true;
            vista_Usuarios.btnGuardar.Enabled = true;
            vista_Usuarios.btnBuscar.Enabled = true;
            vista_Usuarios.dtgUsuarios.ClearSelection();
            vista_Usuarios.ptbUsuario.Image = null;
            cargaInicial();
            vo_User = new VO_User();

        }


        //Metodo que se desencadena tras dar click sobre una fila del datagridview
        private void Click_Fila(object sender, DataGridViewCellEventArgs e)
        {
            vista_Usuarios.ptbUsuario.Image = null;
            vista_Usuarios.txtCurp.Enabled = false;
            vista_Usuarios.btnBuscar.Enabled = false;
            vista_Usuarios.btnGuardar.Enabled = false;
            vista_Usuarios.cmbCargo.DataSource = null;
            vista_Usuarios.cmbCargo.Items.Clear();
            vista_Usuarios.cmbCargo.Items.Insert(0, vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[1].Value.ToString());
            vista_Usuarios.cmbCargo.SelectedIndex = 0;
            vista_Usuarios.txtCurp.Text= vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[2].Value.ToString();
            vista_Usuarios.txtNombre.Text = vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
            vista_Usuarios.txtApellidoP.Text = vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[4].Value.ToString();
            vista_Usuarios.txtApellidoM.Text = vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[5].Value.ToString();
            vista_Usuarios.txtUser.Text = vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[7].Value.ToString();
            vista_Usuarios.txtTelefono.Text = vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[9].Value.ToString();
            vista_Usuarios.txtEmail.Text = vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[10].Value.ToString();
            byte[] datos = (byte[])vista_Usuarios.dtgUsuarios.Rows[vista_Usuarios.dtgUsuarios.CurrentRow.Index].Cells[11].Value;
            MemoryStream ms = new MemoryStream(datos);
            if (ms.Length!=0)
            {
                vista_Usuarios.ptbUsuario.Image = Bitmap.FromStream(ms);
            }            
        }


        //Metodo que se encarga de buscar si en BDs existe el registro de un ciudadano
        private void Click_Buscar(object sender, EventArgs e)
        {
            if (vista_Usuarios.txtCurp.Text == string.Empty)
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Ciudadano.Curp = vista_Usuarios.txtCurp.Text;
                List<Object> lstCiudadano = InstanciaCiudadanos.Listar(vo_Ciudadano);
                if (lstCiudadano.Count > 0)
                {
                    vo_Ciudadano = (VO_Ciudadano)lstCiudadano[0];
                    vista_Usuarios.txtNombre.Text = vo_Ciudadano.Nombre;
                    vista_Usuarios.txtApellidoP.Text = vo_Ciudadano.APaterno;
                    vista_Usuarios.txtApellidoM.Text = vo_Ciudadano.AMaterno;
                    vista_Usuarios.btnEditar.Enabled = false;
                    vista_Usuarios.btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No existe registros...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vista_Usuarios.dtgUsuarios.ClearSelection();
        }
        #endregion
    }
}
