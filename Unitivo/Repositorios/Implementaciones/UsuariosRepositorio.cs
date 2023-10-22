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

                //necesito verificar que un correo no este asociado a una cuenta existente
                if(_contexto?.Usuarios.Any(u => u.NombreUsuario == x.NombreUsuario) ?? false){
                    throw new ValidationException("El nombre de usuario ya existe en la base de datos");
                }

                x.Estado = true;
                x.FechaCreacion = DateTime.Now;

                _contexto?.Usuarios.Add(x);
                return true;
            }
            catch{
                return false;
            }
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return _contexto?.Usuarios.Find(id)!;
        }

        public List<Usuario> BuscarUsuario(object parametro){
            if(int.TryParse(parametro.ToString(), out int id)){
                List<Usuario> usuarios = _contexto?.Usuarios.Where(u => u.Id == id).ToList()!;
                return usuarios;
            }
            else if( parametro is string)
            {
                string cadena = (string)parametro;
                return _contexto?.Usuarios.Where(u => u.NombreUsuario!.Contains(cadena)).ToList()!;
            }
            else{
                return new List<Usuario>();
            }
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
            return _contexto?.Usuarios.ToList()!;
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
