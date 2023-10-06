using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;

namespace Unitivo.Presentacion.Administrador
{
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }


        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBNombreProducto.Text) ||
                CBCategoriaProducto.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TBStockProducto.Text) ||
                string.IsNullOrWhiteSpace(TBPrecioProducto.Text) ||
                CBTalleProducto.SelectedIndex == -1 ||
                CBMarcaProducto.SelectedIndex == -1)
            {
                // Mostrar un mensaje de error si al menos un campo está vacío.
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Mostrar un mensaje de éxito.
                MessageBox.Show("Producto Modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
