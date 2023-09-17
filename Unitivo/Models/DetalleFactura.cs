using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class DetalleFactura
{
    public int IdDetalleVenta { get; set; }

    public int CantidadDetalle { get; set; }

    public decimal PrecioDetalle { get; set; }

    public int IdFactura { get; set; }

    public int IdProducto { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
