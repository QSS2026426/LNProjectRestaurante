using System;
using System.Collections.Generic;

namespace LNProject.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
