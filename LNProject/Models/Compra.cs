using System;
using System.Collections.Generic;

namespace LNProject.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int IdCliente { get; set; }

    public DateTime FechaCompra { get; set; }

    public decimal Total { get; set; }

    public decimal Pago { get; set; }

    public decimal? Cambio { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
