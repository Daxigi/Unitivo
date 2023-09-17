using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string DescripcionCategoria { get; set; } = null!;

    public bool EstadoCategoria { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
