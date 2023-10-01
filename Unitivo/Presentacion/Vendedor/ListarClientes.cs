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



        private void CargarClientes()
        {
            List<Cliente> clientes = clienteRepositorio.ListarClientesActivos();
            dgvListarCliente.Rows.Clear();
            dgvListarCliente.Refresh();
            foreach (Cliente cliente in clienteRepositorio.ListarClientes())
            {
                dgvListarCliente.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
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
                    dgvListarCliente.Rows.Clear();
                    dgvListarCliente.Refresh();
                    foreach (Cliente cliente in clientes)
                    {
                        dgvListarCliente.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
                    }
                }
                else
                {
                    dgvListarCliente.Rows.Clear();
                    dgvListarCliente.Refresh();
                }
            }
            else
            {
                CargarClientes();
            }
        }
    }
}
