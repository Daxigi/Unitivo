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
using Unitivo.Presentacion.Vendedor;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BModificarCliente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarCliente
            ModificarCliente modificarClienteForm = new ModificarCliente(1);

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarClienteForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarCliente
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de cliente o realizar otras acciones necesarias
                // después de modificar el cliente.
            }
        }

    }
}
