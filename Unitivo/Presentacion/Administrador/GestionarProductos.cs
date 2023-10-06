using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Presentacion.Logica;
using Unitivo.Presentacion.SuperAdministrador;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarProductos : Form
    {
        public GestionarProductos()
        {
            InitializeComponent();
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarProducto
            ModificarProducto modificarProductoForm = new ModificarProducto();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarProductoForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarProducto
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de producto o realizar otras acciones necesarias
                // después de modificar el producto.
            }
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaProductos.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

    }
}
