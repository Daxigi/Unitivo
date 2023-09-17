using System;
using System.Collections.Generic;

namespace Unitivo.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string ApellidoCliente { get; set; } = null!;

    public string DniCliente { get; set; } = null!;

    public string TelefonoCliente { get; set; } = null!;

    public string? DireccionCliente { get; set; }

    public string CorreoCliente { get; set; } = null!;

    public bool EstadoCliente { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? UsuarioCreacion { get; set; }

    public int? UsuarioModificacion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
