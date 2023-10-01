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

namespace Unitivo.Presentacion.Vendedor
{
    public partial class ListarClientes : Form
    {

        public ListarClientes()
        {
            InitializeComponent();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }


        private void BEditarCliente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarCliente
            ModificarCliente modificarClienteForm = new ModificarCliente();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarClienteForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarCliente
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de clientes o realizar otras acciones necesarias
                // después de modificar el cliente.
            }
        }




        private void DgvListarClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
