using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string NombreEmpleado { get; set; } = null!;

    public string ApellidoEmpleado { get; set; } = null!;

    public string DniEmpleado { get; set; } = null!;

    public string TelefonoEmpleado { get; set; } = null!;

    public string DireccionEmpleado { get; set; } = null!;

    public string CorreoEmpleado { get; set; } = null!;

    public bool EstadoEmpleado { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
