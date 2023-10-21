using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Unitivo.Modelos;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {

        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

    

        public UsuarioValidator()
        {
            //nombre contrase;a perfil confirmarcontrase;a idempleado
            //validar nombre
            RuleFor(x => x.NombreUsuario)
                .NotEmpty().WithMessage("El campo Nombre es obligatorio")
                .Length(3, 50).WithMessage("El campo Nombre debe tener entre 3 y 50 caracteres")
                ;
            //validar apellido
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("El campo Password es obligatorio")
                .Length(3, 50).WithMessage("El campo Apellido debe tener entre 3 y 50 caracteres")
                ;
            //validar IdPerfil
            RuleFor(x => x.IdPerfil)
                .NotEmpty().WithMessage("El campo IDPerfil es obligatorio")
                .Must(x => x > 0).WithMessage("El campo IDPerfil debe ser mayor a 0")
                //El idPerfil debe existir en la base de datos, en la tabla perfiles
                ;
            //validar telefono
            RuleFor(x => x.IdEmpleado)
                .NotEmpty().WithMessage("El campo Telefono es obligatorio")
                ;
        }

        private bool ExisteNombreUsuario(string nombreUsuario)
        {
            if(empleadoRepositorio.BuscarEmpleadosPorMail(nombreUsuario) != null){
                return false;
            }else{
                return true;
            }
        }
        private bool ExistePerfil(int idPerfil)
        {
            // var perfiles = perfilesRepositorio.ObtenerPerfiles();
            return true;
        }
    }
}
