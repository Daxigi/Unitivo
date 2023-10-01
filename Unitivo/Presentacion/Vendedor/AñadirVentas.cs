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

namespace Unitivo.Formularios.Vendedor
{
    public partial class AñadirVentas : Form
    {
        public AñadirVentas()
        {
            InitializeComponent();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBDniCliVenta.Text))
            {
                // El TextBox está vacío, así que debes mostrar el formulario BuscarCliente como un diálogo modal.
                BuscarCliente buscarClienteForm = new BuscarCliente();
                DialogResult result = buscarClienteForm.ShowDialog();

                // Aquí puedes manejar el resultado si es necesario.
                if (result == DialogResult.OK)
                {
                    // Realiza alguna acción después de seleccionar un cliente en el formulario BuscarCliente.
                }
            }
            else
            {
                // El TextBox no está vacío, realiza alguna acción o muestra un mensaje de error.
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBProductoVenta.Text))
            {
                // El TextBox está vacío, así que debes mostrar el formulario BuscarProducto como un diálogo modal.
                BuscarProducto buscarProductoForm = new BuscarProducto();
                DialogResult result = buscarProductoForm.ShowDialog();

                // Aquí puedes manejar el resultado si es necesario.
                if (result == DialogResult.OK)
                {
                    // Realiza alguna acción después de seleccionar un producto en el formulario BuscarProducto.
                }
            }
            else
            {
                // El TextBox no está vacío, realiza alguna acción o muestra un mensaje de error.
            }
        }




    }
}
