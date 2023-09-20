using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Unitivo.Models;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;

namespace Unitivo.Repositorios.Implementaciones
{
    public class  UsuariosRepositorio : UsuarioInterface
    {
        private readonly UnitivoContext? _contexto;

        public UsuariosRepositorio(){
            _contexto = Contexto.dbContexto;
        }

        private void CargarEmpleados(){
            _contexto?.Empleados.Load();

            LocalStorage.empleados = _contexto?.Empleados.ToList();
        }
        public void AgregarUsuario(Usuario usuario)
        {
            _contexto?.Usuarios.Add(usuario);
        }

        public Usuario BuscarUsuario(int id)
        {
            return _contexto?.Usuarios.Find(id)!;
        }

        public bool EliminarUsuario(int id)
        {
            Usuario? usuario = _contexto?.Usuarios.Find(id);
            if(usuario == null) return false;
            usuario.EstadoUsuario = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Usuario> ListarUsuarios()
        {
            if(LocalStorage.empleados.IsNullOrEmpty()){
                CargarEmpleados();
            }
            if(LocalStorage.usuarios.IsNullOrEmpty()){
                LocalStorage.usuarios = _contexto?.Usuarios.ToList();
            }
            return LocalStorage.usuarios!;
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            _contexto?.Usuarios.Update(usuario);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
    }
}
