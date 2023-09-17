using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public int IdUsuario { get; set; }

    public int IdCliente { get; set; }

    public bool EstadoFactura { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
