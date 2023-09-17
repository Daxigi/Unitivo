using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Talle
{
    public int IdTalle { get; set; }

    public string DescripcionTalle { get; set; } = null!;

    public bool EstadoTalle { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
