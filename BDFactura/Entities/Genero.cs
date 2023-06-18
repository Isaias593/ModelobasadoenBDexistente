using System;
using System.Collections.Generic;

namespace BDFactura.Entities;

public partial class Genero
{
    public int Id { get; set; }

    public string NombreGenero { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Vendedor> Vendedors { get; set; } = new List<Vendedor>();
}
