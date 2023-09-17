using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Perfile
{
    public int IdPerfil { get; set; }

    public string DescripcionPerfil { get; set; } = null!;

    public bool EstadoPerfil { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
