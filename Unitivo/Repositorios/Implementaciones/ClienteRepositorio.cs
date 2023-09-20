using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Models;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;

namespace Univivo.Repositorios.Implementaciones
{
    public class ClienteRepositorio : ClienteInterface{
        private readonly UnitivoContext? _contexto;

        public ClienteRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public void AgregarCliente(Cliente cliente){
            _contexto?.Clientes.Add(cliente);
        }

        public bool EliminarCliente(int id){
            Cliente? cliente = _contexto?.Clientes.Find(id);
            if(cliente == null) return false;
            cliente.EstadoCliente = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarCliente(Cliente cliente){
            _contexto?.Clientes.Update(cliente);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public Cliente BuscarCliente(int id){
           return _contexto?.Clientes.Find(id)!;
        }
        
        public List<Cliente> ListarClientes(){
            return _contexto?.Clientes.ToList()!;
        }

    }
}