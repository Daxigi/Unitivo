using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;
using Unitivo.Validators;

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
        public bool AgregarUsuario(Usuario x)
        {
            try{
                var validator = new UsuarioValidator();
                var result = validator.Validate(x);
                if(!result.IsValid){
                    StringBuilder sb = new StringBuilder();
                    foreach(var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }


                if(_contexto?.Usuarios.Find(x.IdEmpleadoNavigation.Correo)){
                    
                }


                _contexto?.Usuarios.Add(x);
                return true;
            }
            catch{
                return false;
            }
        }

        public Usuario BuscarUsuario(int id)
        {
            return _contexto?.Usuarios.Find(id)!;
        }

        public bool EliminarUsuario(int id)
        {
            Usuario? usuario = _contexto?.Usuarios.Find(id);
            if(usuario == null) return false;
            usuario.Estado = false;
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

        public List<Usuario> ListarUsuariosActivos()
        {
            return _contexto?.Usuarios.Where(u => u.Estado == true).ToList()!;
        }
        public bool ModificarUsuario(Usuario usuario)
        {
            _contexto?.Usuarios.Update(usuario);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
    }         
}
