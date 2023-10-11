using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Talle
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
