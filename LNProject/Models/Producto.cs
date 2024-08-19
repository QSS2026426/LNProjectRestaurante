using System;
using System.Collections.Generic;

namespace LNProject.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();
}
