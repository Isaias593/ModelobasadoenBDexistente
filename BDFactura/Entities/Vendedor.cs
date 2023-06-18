using System;
using System.Collections.Generic;

namespace BDFactura.Entities;

public partial class Vendedor
{
    public int Id { get; set; }

    public string NombreComple { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string FechaRegistro { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public int Generoid { get; set; }

    public virtual Genero Genero { get; set; } = null!;
}
