using System;
using System.Collections.Generic;

namespace LNProject.Models;

public partial class Administrativo
{
    public int IdAdministrativo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool Estado { get; set; }
}
