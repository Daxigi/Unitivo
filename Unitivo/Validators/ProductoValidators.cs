using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Unitivo.Modelos;

namespace Unitivo.Validators
{
    public class ProductoValidator : AbstractValidator<Producto>
    {
        public ProductoValidator()
        {
            //validar dni 
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El campo Dni es obligatorio")
                ;
            //validar nombre
            RuleFor(x => x.IdCategoria)
                .NotEmpty().WithMessage("El campo Categoria es obligatorio")
                ;
            //validar apellido
            RuleFor(x => x.IdTalle)
                .NotEmpty().WithMessage("El campo Talle es obligatorio")
                ;
            //validar email
            RuleFor(x => x.Stock )
                .NotEmpty().WithMessage("El campo Stock es obligatorio")
                .Must(x => x > 0).WithMessage("El campo Stock debe ser mayor a 0")
                ;
            //validar telefono
            RuleFor(x => x.Precio)
                .NotEmpty().WithMessage("El campo Telefono es obligatorio")
                .Must(x => x > 0).WithMessage("El campo Precio debe ser mayor a 0")
                ;
            //validar imagen
            RuleFor(x => x.Imagen)
                .NotEmpty().WithMessage("El campo Imagen es obligatorio")
                ;
        }
    }
}
