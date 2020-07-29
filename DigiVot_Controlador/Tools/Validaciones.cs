using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Controlador
{
    class Validaciones
    {
        public bool Buscar(string TextoABuscar, DataGridView grid)
        {
            foreach (DataGridViewRow fila in grid.Rows)
            {
                if (fila.Cells[0].Value.ToString() == TextoABuscar)
                {
                    return true;
                }
            }
            return false;
        }
        public bool revisaContenidoGrid(DataGridView data)
        {
            int num = data.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible modificar!!! tabla sin datos.......");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool revisaSeleccionado(DataGridView data)
        {
            if (data.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaModificacion(int idEleccion, int idPartido, bool verifica)
        {
            if (idEleccion == -1 && idPartido == -1 && verifica != true)
            {
                MessageBox.Show("Modifique al menos un dato.....");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaModificacionPartido(string Partido, bool verifica)
        {
            if (Partido == string.Empty && verifica != true)
            {
                MessageBox.Show("Datos necesarios.....");
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool Vacios (Form vista,ErrorProvider erp){
            bool checa = true;
            erp.Clear();
            foreach (Control y in vista.Controls)
            {
                foreach ( Control x in y.Controls)
                {
                    if (x is TextBox &&  x.Text == string.Empty && x.Enabled == true)
                    {
                        erp.SetError(x, "Ingrese Valor");
                        checa = false;
                    }
                   
                    

                    if (x is Guna.UI2.WinForms.Guna2ComboBox)
                    {
                        ComboBox z = (ComboBox)x;
                        if (z.Items.Count == 1)
                        {
                            erp.SetError(x, "Seleccione Valor");
                            checa = false;
                        }
                        else if (z.SelectedIndex == 0) {
                            erp.SetError(x, "Seleccione Valor");
                            checa = false;
                        }
                       
                    }

                    if (x is PictureBox )
                    {
                        PictureBox z = (PictureBox)x;
                        if (z.Image == null)
                        {
                            erp.SetError(x, "Seleccione una imagen");
                            checa = false;
                        }

                    }
                }
               
            }

            return checa;
        }
    }
}
