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

    }
}
