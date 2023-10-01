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
using Unitivo.Repositorios.Implementaciones;
using Univivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class BuscarCli : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        public BuscarCli()
        {
            InitializeComponent();
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
    }
}
