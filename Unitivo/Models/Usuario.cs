using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string ContraseñaUsuario { get; set; } = null!;

    public int IdPerfil { get; set; }

    public int IdEmpleado { get; set; }

    public bool EstadoUsuario { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Perfile IdPerfilNavigation { get; set; } = null!;
}
