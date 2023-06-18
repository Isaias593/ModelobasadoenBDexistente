using System;
using System.Collections.Generic;

namespace BDFactura.Entities;

public partial class Factura
{
    public int Id { get; set; }

    public int Total { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Estado { get; set; }

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    public double TotalXproducto { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();
}
