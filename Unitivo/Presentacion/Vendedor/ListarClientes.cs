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
using Univivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class ListarClientes : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        public ListarClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
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

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteRepositorio.ListarClientesActivos();
            DataGridViewListarClientes.Rows.Clear();
            DataGridViewListarClientes.Refresh();
            foreach (Cliente cliente in clienteRepositorio.ListarClientes())
            {
                DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
            }
        }


        private void BBuscar_Click(object sender, EventArgs e)
        {
            object parametro = TBBuscar.Text;

            if (parametro != null)
            {
                List<Cliente> clientes = clienteRepositorio.BuscarCliente(parametro);
                if (clientes != null)
                {
                    DataGridViewListarClientes.Rows.Clear();
                    DataGridViewListarClientes.Refresh();
                    foreach (Cliente cliente in clientes)
                    {
                        DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
                    }
                }
                else
                {
                    DataGridViewListarClientes.Rows.Clear();
                    DataGridViewListarClientes.Refresh();
                }
            }
            else
            {
                CargarClientes();
            }
        }


    }
}
