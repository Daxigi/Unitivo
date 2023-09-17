using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public decimal PrecioProducto { get; set; }

    public int StockProducto { get; set; }

    public bool EstadoProducto { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdTalle { get; set; }

    public string? Imagen { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Categorium? IdCategoriaNavigation { get; set; }

    public virtual Talle? IdTalleNavigation { get; set; }

}
