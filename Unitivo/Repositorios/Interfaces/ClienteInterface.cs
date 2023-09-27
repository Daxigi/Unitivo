using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorio.Interfaces
{
    public interface ClienteInterface
    {
        public void AgregarCliente(Cliente cliente);
        public bool EliminarCliente(int id);
        public bool ModificarCliente(Cliente cliente);
        public Cliente BuscarCliente(int id);
        public List<Cliente> ListarClientes();

    }
}